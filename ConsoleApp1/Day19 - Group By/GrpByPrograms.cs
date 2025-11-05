using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1.Day19___Group_By
{
    internal class GrpByPrograms
    {

        class Sale
        {
            public int Id { get; set; }
            public string Product { get; set; }
            public string Region { get; set; }
            public int Quantity { get; set; }
            public int Amount { get; set; }
            public string SalesPerson { get; set; }
            public override string ToString()
            {
                return $"ID: {Id} | Product: {Product} | Amount: {Amount}";
            }


        }
        public static void Demo()
        {
            var sales = new List<Sale>
            {
                new Sale { Id = 1, Product = "Laptop", Region = "South", Quantity = 10, Amount = 500000, SalesPerson = "Arun" },
                new Sale { Id = 2, Product = "Mouse", Region = "North", Quantity = 25, Amount = 25000, SalesPerson = "Meena" },
                new Sale { Id = 3, Product = "Keyboard", Region = "East", Quantity = 15, Amount = 30000, SalesPerson = "Kumar" },
                new Sale { Id = 4, Product = "Monitor", Region = "West", Quantity = 8, Amount = 120000, SalesPerson = "Sita" },
                new Sale { Id = 5, Product = "Laptop", Region = "North", Quantity = 12, Amount = 600000, SalesPerson = "Arun" },
                new Sale { Id = 6, Product = "Mouse", Region = "South", Quantity = 30, Amount = 30000, SalesPerson = "Meena" },
                new Sale { Id = 7, Product = "Monitor", Region = "East", Quantity = 6, Amount = 90000, SalesPerson = "Kumar" },
                new Sale { Id = 8, Product = "Keyboard", Region = "West", Quantity = 10, Amount = 20000, SalesPerson = "Sita" },
                new Sale { Id = 9, Product = "Laptop", Region = "East", Quantity = 5, Amount = 250000, SalesPerson = "Arun" },
                new Sale { Id = 10, Product = "Mouse", Region = "West", Quantity = 20, Amount = 20000, SalesPerson = "Meena" },
            };

            // All Sales made by Arun
            var salesByArun = sales.Where((sale) => sale.SalesPerson == "Arun");
            Console.WriteLine("-------------- > Sales by Arun");
            Console.WriteLine(string.Join("\n", salesByArun.ToList()));
            Console.WriteLine("---------------------------------------\n");

            // all sales where quantity > 10
            var bigSales = sales.Where((sale) => sale.Quantity > 10);
            Console.WriteLine("-------------- > Sales where Quantity > 10");
            Console.WriteLine(string.Join("\n", bigSales));
            Console.WriteLine("---------------------------------------\n");

            // products sold in south region
            var productsInSouth = sales.Where((sale) => sale.Region == "South").Select((sale) => sale.Product);
            Console.WriteLine("-------------- > Sales in South Region");
            Console.WriteLine(string.Join("\n", productsInSouth));
            Console.WriteLine("---------------------------------------\n");

            // sales amount descending order
            var salesInDesc = sales.OrderByDescending((sale) => sale.Amount);
            Console.WriteLine("-------------- > Sales Ordered Descending by Amount");
            Console.WriteLine(string.Join("\n", salesInDesc));
            Console.WriteLine("---------------------------------------\n");

            // distinct products sold
            var distinctProducts = sales.Select((sale) => sale.Product).Distinct();
            Console.WriteLine("-------------- > Distinct Products Sold in Sale");
            Console.WriteLine(string.Join(", ", distinctProducts));
            Console.WriteLine("---------------------------------------\n");

            // total sales amount
            int totalSalesAmount = sales.Select((sale) => sale.Amount).Sum();
            Console.WriteLine("-------------- > Total Sales Amount:");
            Console.WriteLine($"Rs. {totalSalesAmount}");
            Console.WriteLine("---------------------------------------\n");


            // calculate average sales amount per product
            var salesPerProduct = sales.GroupBy((sale) => sale.Product);

            foreach (var productGroup in salesPerProduct)
            {
                var prices = productGroup.Select((sale) => sale.Amount);
                Console.WriteLine($"Product: {productGroup.Key} - Average Sale Amount: {prices.Average()}");
            }


        }
    }
}
