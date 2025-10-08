

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nEnter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            BasicExcercise.EvenNumberCheck(number);

            Console.Write("\nEnter your grade (0-100): ");
            int grade = Convert.ToInt32(Console.ReadLine());
            BasicExcercise.FindGrade(grade);

            Console.Write("\nEnter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter an operator +, -, *, /: ");
            char op = Convert.ToChar(Console.ReadLine());
            BasicExcercise.SimpleCalc(a, b, op);

            Console.Write("\nEnter day number, it must be between 1 and 7: ");
            int dayNumber = Convert.ToInt32(Console.ReadLine());
            BasicExcercise.FindDay(dayNumber);
        }
    }
}
