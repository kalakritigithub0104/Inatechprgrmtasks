using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class ArithOp
    {
        public void Add(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }
        public void Sub(int num1, int num2)
        {
            Console.WriteLine(num1 - num2);
        }
    }
    class Deri : ArithOp
    {
        public void Mul(int num1, int num2)
        {
            Console.WriteLine(num1 * num2);
        }
        public void Div(int num1, int num2)
        {
            Console.WriteLine(num1 / num2);
        }
        public static void Main(string[] args)
        {
            int select;
            Deri obj = new Deri();
            Console.WriteLine("Enter two numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose an operation\n1.Addition\n2.Subtraction\n3.Multiplication\n4.Division");
            select = Convert.ToInt32(Console.ReadLine());
            switch (select)
            {
                case 1:
                    obj.Add(num1, num2);
                    break;
                case 2:
                    obj.Sub(num1, num2);
                    break;
                case 3:
                    obj.Mul(num1, num2);
                    break;
                case 4:
                    obj.Div(num1, num2);
                    break;
                default:
                    Console.WriteLine("Wrong choice");
                    break;
            }
        }
    }
}
