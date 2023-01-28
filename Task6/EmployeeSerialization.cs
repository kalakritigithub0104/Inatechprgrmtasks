using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class EmployeeSerialization
    {
        public int EmpId { get; set; }
        public string? EmpName { get; set; }
        public string? EmpGender { get; set; }
        public int EmpAge { get; set; }

        public void readfEmp()
        {
            FileStream emp = new FileStream("C:\\Inatechprograms\\EmpSer.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(emp);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadToEnd();
            Console.WriteLine(str);
        }
        public static void Main(string[] args)
        {
            EmployeeSerialization emp = new EmployeeSerialization();
            Console.WriteLine("Enter Employee Name");
            emp.EmpName = Console.ReadLine();
            Console.WriteLine("Enter Employee Gender");
            emp.EmpGender = Console.ReadLine();
            Console.WriteLine("Enter Employee ID:");
            emp.EmpId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Age:");
            emp.EmpAge = Convert.ToInt32(Console.ReadLine());

            FileStream Emp = new FileStream(@"C:\Inatechprograms\EmpSer.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(Emp);
            sw.Write(emp.EmpName);
            sw.Write(emp.EmpGender);
            sw.Write(emp.EmpAge);
            sw.Write(emp.EmpId);
            sw.Flush();
            sw.Close();
            Emp.Close();
            emp.readfEmp();
        }
    }


}
    

