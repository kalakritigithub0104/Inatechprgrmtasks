using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class MultiplicationTable
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Multiplication table of {0} is: ", number);
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", number, i, number * i);
            }
            
        }
    }

}
