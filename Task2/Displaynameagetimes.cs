using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Displaynameagetimes
    {
        public static void Main()
        {
            string Name;
            int Age;
            Console.WriteLine("Enter your Name");
            Name=  Console.ReadLine();
            Console.WriteLine("Enter your Age");
            Age=Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= Age; i++)
            {
                Console.WriteLine(Name);
            }
        }
    }
}
