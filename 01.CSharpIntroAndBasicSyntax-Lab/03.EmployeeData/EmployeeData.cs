using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string emplyeeName = Console.ReadLine();
            int employeeAge = int.Parse(Console.ReadLine());
            int employeeID = int.Parse(Console.ReadLine());
            decimal employeeSalary = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {emplyeeName}");
            Console.WriteLine($"Age: {employeeAge}");
            Console.WriteLine($"Employee ID: {employeeID:D8}");
            Console.WriteLine($"Salary: {employeeSalary:f2}");

        }
    }
}
