using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Day4
    {

        public static void exampleArrayProgram()
        {
            ArraysExample arraysExample = new ArraysExample();
        }
        public static void start()
        {
            Console.WriteLine("==========================================================");
            Console.Write("Enter Product Amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Select Delivery Type:\n1. Expedited 2. Standard 3. Express");
            int deliveryChoice = Convert.ToInt32(Console.ReadLine());
            DeliveryType deliveryType = deliveryChoice switch
            {
                1 => DeliveryType.Expedited,
                2 => DeliveryType.Standard,
                3 => DeliveryType.Express,
                _ => DeliveryType.Standard
            };

            Console.Write("Enter Discount Code (or press Enter to skip): ");
            string discountCode = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(discountCode))
            {
                discountCode = "";
            }

            Console.Write("Enter Customer State (e.g., CA, TX, FL): ");
            string customerState = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(customerState))
            {
                customerState = "CA";
            }

            Console.Write("Enter Customer Country: ");
            string customerCountry = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(customerCountry))
            {
                customerCountry = "USA";
            }

            Console.WriteLine("Select Customer Type:\n1. Regular 2. VIP");
            int customerTypeChoice = Convert.ToInt32(Console.ReadLine());
            CustomerType customerType = customerTypeChoice switch
            {
                1 => CustomerType.Regular,
                2 => CustomerType.VIP,
                _ => CustomerType.Regular
            };

            
            Console.Write("\n\n");

            OrderSystem.AddOrder(amount, deliveryType, discountCode, customerState, customerCountry, customerType);
        }
    }
}
