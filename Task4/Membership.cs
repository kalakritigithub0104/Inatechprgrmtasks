using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Membership
    {
        public static void Main()
        {
            Console.WriteLine("Mention your Membership");
            string mem=Console.ReadLine();
            switch(mem)
            {
                case "Silver":Console.WriteLine("3 days accomodation at Resort");
                    break;
                case "Gold":Console.WriteLine("5 days accomodation at Resort & 2 Dinners on the house");
                    break;
                case "Platinum":Console.WriteLine("7 days accomodation at Resort & 5 Dinners on the house");
                    break;
                default:Console.WriteLine("Get a Membership");
                    break;
            }
        }
    }
}
