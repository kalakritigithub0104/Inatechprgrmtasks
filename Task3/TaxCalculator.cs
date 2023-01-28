using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class TaxCalculator
    {
        public virtual void calculateTax()
            {
                Console.WriteLine("VAT @ 20%");
            }
        

        public class GSTCalculator : TaxCalculator
        {
            public override void calculateTax()
            {
                Console.WriteLine("GST @ 12%");
            }
        }

        public class Program
        {
            static void Main(string[] args)
            {
                TaxCalculator taxCalc = new TaxCalculator();
                taxCalc.calculateTax();

                GSTCalculator gstCalc = new GSTCalculator();
                gstCalc.calculateTax();
            }
        }

        
    }
}
