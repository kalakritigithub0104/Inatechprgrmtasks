using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class TVChannelPackage
    {
        public static void Main()
        {
            string Package;

            Console.Write("Package A contains-South Special,Children's Club,Movies");
            Console.WriteLine("Package B contains-News,Sports,Movies,Regional");
            Console.WriteLine("Package C contains-Discovery, History,National");
            Console.WriteLine("Enter your Package");
            Package=Console.ReadLine();
            switch(Package)
            {
                case "A":Console.WriteLine("Rs.250");
                    break;
                case "B":Console.WriteLine("Rs.450");
                    break;
                case "C":Console.WriteLine("Rs.350");
                    break;
                default: Console.WriteLine("Please enter the package you want");
                    break;

            }

        }
    }
}
