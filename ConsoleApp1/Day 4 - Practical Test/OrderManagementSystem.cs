using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum DeliveryType
{
    Expedited,
    Standard,
    Express
}

public enum PaymentMethod
{
    CreditCard,
    PayPal,
    BankTransfer
}

public enum CustomerType
{
    VIP,
    Regular,
    New
}

public enum OrderPriority
{
    High,
    Medium,
    Low
}



namespace ConsoleApp1
{
    public class OrderSystem
    {
            static readonly int standardShippingCharge = 50;
            static readonly int shippingChargeSkipThreshold = 500;

            static readonly Dictionary<DeliveryType, string> deliveryDates = new Dictionary<DeliveryType, string>()
            {
                { DeliveryType.Expedited, "2 Business Days" },
                { DeliveryType.Standard, "5-7 Business Days" },
                { DeliveryType.Express, "1 Business Day" }
            };

            static readonly Dictionary<string, int> discounts = new Dictionary<string, int>()
            {
                { "SAVE10", 10 },
                { "SAVE20", 20 },
            };

            static readonly Dictionary<string, double> stateTaxRates = new Dictionary<string, double>()
            {
                { "CA", 8 },
                { "TX", 6.25 },
                { "FL", 7 },
            };

            static readonly int freeGiftThreshold = 500;

        public static void AddOrder(int amount, DeliveryType deliveryType, string discountCode, string customerState, string customerCountry, CustomerType customerType)
        {
            Console.WriteLine($"+ Received an order of amount ${amount} with {deliveryType} delivery to be delivered at {customerState}, {customerCountry}");
            Console.WriteLine("==============================================================");

            int totalAmount = amount;

            // Coupon code discount
            double discountFromCode = calculateDiscountAmount(discountCode);
            totalAmount -= (int)((discountFromCode / 100) * totalAmount);
            Console.WriteLine($"- {discountFromCode}% applied using code {discountCode}.\n   New amount: ${totalAmount}");

            // Primary amount based discount
            int amountBasedDiscountPercentage = discountBasedOnAmount(amount);
            if (amount >= 1000)
            {
                totalAmount -= (int)(amount / 10);
                Console.WriteLine($"- Discount of 10% applied for orders above $1000.\n  New amount: ${totalAmount}");
            }
            else if (amount >= 500)
            {
                totalAmount -= (int)(0.5 * amount);
                Console.WriteLine($"- Discount of 5% applied for orders above $500.\n  New amount: ${totalAmount}");
            }

            // Customer type based discount
            if (customerType == CustomerType.VIP)
            {
                totalAmount -= (int)(0.15 * amount);
                Console.WriteLine($"- Additional 15% discount applied for VIP customers.\n  New amount: ${totalAmount}");
            }
            else if (customerType == CustomerType.Regular)
            {
                totalAmount -= (int)(0.05 * amount);
                Console.WriteLine($"- Additional 5% discount applied for New customers.\n  New amount: ${totalAmount}");
            }

            // Calculate shipping charge based on amount
            int shippingCharge = shippingChargeInUSD(amount);
            if (shippingCharge == 0)
            {
                Console.WriteLine("- Shipping charge: $0 (Free shipping for orders above $500)");
            }
            else
            {
                totalAmount += shippingCharge;
                Console.WriteLine($"+ Shipping charge: ${shippingCharge}");
            }

            // Calculate state tax
            int stateTax = (int)calculateStateTax(customerState, totalAmount);
            if (stateTax > 0)
            {
                totalAmount += stateTax;
                Console.WriteLine($"+ State tax of {stateTaxRates[customerState]}% applied for {customerState}. Tax amount: ${stateTax}.\n  New amount: ${totalAmount}");
            }


            // Calculate shipping charge based on country
            int countryDeliveryCharge = internationalShippingFee(customerCountry, amount);
            Console.WriteLine("+ International shipping charge: +$" + countryDeliveryCharge);
            totalAmount += countryDeliveryCharge;

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"|        Final amount to be paid: ${totalAmount}            |");
            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine("Select Payment Method:\n1. CreditCard 2. PayPal 3. Bank Transfer (default: CreditCard)");
            int paymentMethodChoice = Convert.ToInt32(Console.ReadLine());
            if (paymentMethodChoice < 1 || paymentMethodChoice > 3)
            {
                paymentMethodChoice = 1; // Default to CreditCard
            }
            PaymentMethod paymentMethod = paymentMethodChoice switch
            {
                1 => PaymentMethod.CreditCard,
                2 => PaymentMethod.PayPal,
                3 => PaymentMethod.BankTransfer,
                _ => PaymentMethod.CreditCard
            };

            if (paymentMethod == PaymentMethod.CreditCard)
            {
                Console.WriteLine("✓ Payment Status: Approved");
            }
            else if (paymentMethod == PaymentMethod.PayPal)
            {
                Console.WriteLine("⏱︎ Payment Status: Pending");
            }
            else if (paymentMethod == PaymentMethod.BankTransfer)
            {
                Console.WriteLine("! Payment Status: Processing");
            }

            // Calculate loyalty points
            int loyaltyPoints = calculateLoyaltyPoints(amount);
            Console.WriteLine($"+ Loyalty points earned: {loyaltyPoints} points");

            // Calculate delivery date
            string estimatedDelivery = calculateDeliveryDate(deliveryType);
            Console.WriteLine($"! Estimated delivery time: {estimatedDelivery}");

            // Determine order priority
            OrderPriority priority = findOrderPriority(amount);
            Console.WriteLine($"! Order Priority: {printOrderPriority(priority)}");

            // Free gift for orders above threshold
            if (amount >= freeGiftThreshold)
            {
                Console.WriteLine("+ Congratulations! You will also receive a free gift with your order.");
            }

            Console.WriteLine("!! Thank you for your purchase!");
            Console.WriteLine("==============================================================");


        }

        static int discountBasedOnAmount(int amount)
        {
            if (amount > 1000) return 10;
            if (amount > 500) return 5;
            return 0;
        }

        static int shippingChargeInUSD(int amount)
        {
            if (amount >= shippingChargeSkipThreshold) return 0;
            return 50;
        }
        
        static string calculateDeliveryDate(DeliveryType deliveryType)
        {
            return deliveryDates[deliveryType];
        }

        static int calculateDiscountAmount(string discountCode)
        {
            if (discounts.ContainsKey(discountCode))
            {
                return discounts[discountCode];
            }
            Console.WriteLine("! No discount applied.");
            return 0;
        }

        static int calculateLoyaltyPoints(int amount)
        {
            if (amount > 1000) return 100;
            if (amount > 500) return 50;
            return 10;
        }

        static double calculateStateTax(string state, int amount)
        {
            if (stateTaxRates.ContainsKey(state))
            {
                return (stateTaxRates[state] / 100) * amount;
            }
            return 0;
        }

        static int internationalShippingFee(string country, int amount)
        {
            switch (country)
            {
                case "Europe":
                    return 30;
                case "USA":
                    return 20;
                case "Canada":
                    return 20;
                case "Mexico":
                    return 20;
                default:
                    return 50;
            }
        }

        static OrderPriority findOrderPriority(int amount)
        {
            if (amount > 1000) return OrderPriority.High;
            if (amount > 500) return OrderPriority.Medium;
            return OrderPriority.Low;
        }

        static string printOrderPriority(OrderPriority priority)
        {
            switch (priority)
            {
                case OrderPriority.High:
                    return "High Priority";
                case OrderPriority.Medium:
                    return "Medium Priority";
                case OrderPriority.Low:
                    return "Low Priority";
                default:
                    return "Low Priority";
            }
        }

    }
}
