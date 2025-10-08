using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Formula {
            
        public static int Sum(int a, int b) {
            return a + b;
        }

        public static int Difference(int a, int b)
        {
            return a - b;
        }

        public static int Product(int a, int b)
        {
            return a * b;
        }

        public static int Area(int radius)
        {
            double area = Math.PI * radius * radius;
            return Convert.ToInt32(area);
        }

    }
}
