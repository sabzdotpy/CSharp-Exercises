using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Console2Task
    {
        public void Message()
        {
            Console.WriteLine("hello from consoleapp2");
        }
    }

    public class K1
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("Add from Library: " + (a + b));
        }

        internal void AddInternal(int a, int b)
        {
            Console.WriteLine("Internal Add: " + (a + b));
        }
    }
}
