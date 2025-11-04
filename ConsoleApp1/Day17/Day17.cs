using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Day17
{
    internal class Day17
    {
        public static void start()
        {
            try
            {

                CalculatorSystem calculator = new CalculatorSystem();
                BackupHelper backup = new BackupHelper();

                bool running = true;

                while (running)
                {
                    Console.WriteLine("\n--- Calculator Menu ---");
                    Console.WriteLine("1. Add");
                    Console.WriteLine("2. Subtract");
                    Console.WriteLine("3. Multiply");
                    Console.WriteLine("4. Divide");
                    Console.WriteLine("5. Exit");
                    Console.WriteLine("6. Start Backup");
                    Console.Write("Choose an option: ");

                    string choice = Console.ReadLine()!;

                    if (choice == "5")
                    {
                        running = false;
                        Console.WriteLine("Exiting...");
                        continue;
                    }

                    if (choice == "6")
                    {
                        backup.StartBackup();
                        continue;
                    }

                    Console.Write("Enter first number: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    int b = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case "1":
                            calculator.Add(a, b);
                            break;
                        case "2":
                            calculator.Sub(a, b);
                            break;
                        case "3":
                            calculator.Mul(a, b);
                            break;
                        case "4":
                            calculator.Div(a, b);
                            break;
                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                FileLogger.Error(ex);
            }
        }
    }
}
