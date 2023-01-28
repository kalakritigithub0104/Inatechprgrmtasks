using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task6
{
    internal class RestaurantDeserts
    {
        class Program
        {
            static void Main(string[] args)
            {
                List<string> desertList = new List<string>();

                desertList.Add("Ice Cream");
                desertList.Add("Fruit Salad");
                desertList.Add("Cheesecake");
                desertList.Add("Chocolate Cake");
                desertList.Add("Strawberry Shortcake");

                string fileName = "RestaurantDeserts.txt";
                FileStream fs = new FileStream(fileName, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);

                foreach (string des in desertList)
                {
                    sw.WriteLine(des);
                }

                sw.Close();
                fs.Close();

                FileInfo fi = new FileInfo(fileName);
                Console.WriteLine("File Name: {0}", fi.Name);
                Console.WriteLine("File Creation Time: {0}", fi.CreationTime);
                Console.WriteLine("File Size: {0} bytes", fi.Length);
                Console.WriteLine("\nDeserts in the Restaurant:");

                StreamReader sr = new StreamReader(fileName);
                string desert;

                while ((desert = sr.ReadLine()) != null)
                {
                    Console.WriteLine(desert);
                }

                sr.Close();

               
            }
        }

    }
}
