using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4and5
{ 
    //Base class
    class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int YearsOfExperience { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, string gender, int experience, double salary)
        {
            this.EmployeeID = id;
            this.Name = name;
            this.Gender = gender;
            this.YearsOfExperience = experience;
            this.Salary = salary;
        }
    }

        //Derived class
        class SalesAndMarketing : Employee
        {
            public SalesAndMarketing(int id, string name, string gender, int experience, double salary) : base(id, name, gender, experience, salary)
            {

            }

            public double CalculateBonus()
            {
                return (Salary * 0.2);
            }

            public double CalculateTotalSalary()
            {
                return (Salary + CalculateBonus());
            }
        }

        //Derived class
        class Production : Employee
        {
            public Production(int id, string name, string gender, int experience, double salary) : base(id, name, gender, experience, salary)
            {

            }

            public double CalculateBonus()
            {
                return (Salary * 0.1);
            }

            public double CalculateTotalSalary()
            {
                return (Salary + CalculateBonus());
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                //Employee for Sales and Marketing
                SalesAndMarketing salesAndMarketingEmployee = new SalesAndMarketing(1, "John", "Male", 5, 10000);
                Console.WriteLine("Employee ID : {0}", salesAndMarketingEmployee.EmployeeID);
                Console.WriteLine("Name : {0}", salesAndMarketingEmployee.Name);
                Console.WriteLine("Gender : {0}", salesAndMarketingEmployee.Gender);
                Console.WriteLine("Years of Experience : {0}", salesAndMarketingEmployee.YearsOfExperience);
                Console.WriteLine("Salary : {0}", salesAndMarketingEmployee.Salary);
                Console.WriteLine("Bonus : {0}", salesAndMarketingEmployee.CalculateBonus());
                Console.WriteLine("Total Salary : {0}", salesAndMarketingEmployee.CalculateTotalSalary());
                Console.WriteLine("************************");

                //Employee for Production
                Production productionEmployee = new Production(2, "Sara", "Female", 4, 10000);
                Console.WriteLine("Employee ID : {0}", productionEmployee.EmployeeID);
                Console.WriteLine("Name : {0}", productionEmployee.Name);
                Console.WriteLine("Gender : {0}", productionEmployee.Gender);
                Console.WriteLine("Years of Experience : {0}", productionEmployee.YearsOfExperience);
                Console.WriteLine("Salary : {0}", productionEmployee.Salary);
                Console.WriteLine("Bonus : {0}", productionEmployee.CalculateBonus());
                Console.WriteLine("Total Salary : {0}", productionEmployee.CalculateTotalSalary());
                Console.WriteLine("************************");

                
            }
        }
    
}
