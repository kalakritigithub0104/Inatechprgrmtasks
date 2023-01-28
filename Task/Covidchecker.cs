using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Covidchecker
    {
        public static void Main() {
            string sol1, sol2, sol3;
            Console.WriteLine("Do you have travel history?Yes or No?");
            sol1=Console.ReadLine();
            if (sol1 == "Yes")
            {
                Console.WriteLine("Do you have temperature?Yes or No?");
                sol2 = Console.ReadLine();
                if (sol2 == "Yes")
                {
                    Console.WriteLine("Do you have cough or sneeze?Yes or No?");
                    sol3 = Console.ReadLine();
                    if (sol3 == "Yes")
                    {
                        Console.WriteLine("Swab test");
                    }
                    else
                    {
                        Console.WriteLine("Quarantine and Fever Medicine");
                    }
                }
                else
                {
                    Console.WriteLine("Home Quarantine for 28 days");
                }

            }
            else {
                Console.WriteLine("Safe, Not COVID-19");
            }
        
        }


    }
}
