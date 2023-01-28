using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Login
    {
        string Email = "abc01@gmail.com";
        string pswd = "abc@01";
        int pin = 1234;
        int pin_num = 1234;
        string Memid = "Abc01";
        long Mob = 9898085648;
        public void validate(string a1,string a2)
        {
            this.Email = a1;
            this.pswd = a2;
            if (a1 == Email && a2 == pswd)
            {
                Console.WriteLine("Welcome,Login successful");
            }
            else 
            {
                Console.WriteLine("Incorrect email or password");
            }
        }
        public void validate(string a1,int a2)
        {
            this.Memid = a1;
            this.pin = a2;
            if(a1==Memid && a2==pin)
            {
                Console.WriteLine("Welcome,Login Successful");
            }
            else
            {
                Console.WriteLine("Incorrect email or password");
            }
        }
        public void validate(long a1,int a2)
        {
            this.Mob = a1;
            this.pin_num= a2;
            if(a1== Mob && a2 == pin_num) 
            {
            Console.WriteLine("Welcome,Login successful");
            }
            else 
            {
                Console.WriteLine("Incorrect email or password");
            }
        }
        public static void Main(string[] args)
        {
            Login lobj=new Login();
            Console.WriteLine("Enter Login Credentials");
            Console.WriteLine("a.Login with Email id and password\t");
            Console.WriteLine("b.Login with Membership id and pin\t");
            Console.WriteLine("c.Login with Mobile number and pin\t");
            string s=Console.ReadLine();
            switch(s)
            {
                case "a":
                    Console.WriteLine("Enter Email id");
                    string Email=Console.ReadLine();
                    Console.WriteLine("Enter password");
                    string pswd=Console.ReadLine();
                    lobj.validate(Email, pswd);
                    break;
                case "b":
                    Console.WriteLine("Enter Membership id");
                    string Memid=Console.ReadLine();
                    Console.WriteLine("Enter pin");
                    int pin=Convert.ToInt32(Console.ReadLine());
                    lobj.validate(Memid, pin);
                    break;
                case "c":
                    Console.WriteLine("Enter Mobile number");
                    long Mob=Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Enter pin");
                    int pin_num= Convert.ToInt32(Console.ReadLine());
                    lobj.validate(Mob, pin_num);
                    break;
                default:
                    Console.WriteLine("Please enter the credentials");
                    break;
            }
        }
    }
}
