using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FilterBase
{
    class FilterBase
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> age = new Dictionary<string, int>();
            Dictionary<string, double> salary = new Dictionary<string, double>();
            Dictionary<string, string> position = new Dictionary<string, string>();

            string[] input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "filter")
            {
                string name = input[0];
                string secondData = input[1];

                int employeeAge;
                double employeeSalary;

                if (int.TryParse(secondData, out employeeAge))
                {
                    age[name] = employeeAge;
                }
                else if (double.TryParse(secondData, out employeeSalary))
                {
                    salary[name] = employeeSalary;
                }
                else
                {
                    position[name] = secondData;
                }
                input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }
            string cases = Console.ReadLine().ToLower();

            if (cases == "age")
            {
                foreach (KeyValuePair<string, int> employee in age)
                {
                    Console.WriteLine($"Name: {employee.Key}");
                    Console.WriteLine($"Age: {employee.Value}");
                    Console.WriteLine(new string('=', 20));
                }
            }
            else if (cases == "salary")
            {
                foreach (KeyValuePair<string, double> employee in salary)
                {
                    Console.WriteLine($"Name: {employee.Key}");
                    Console.WriteLine($"Salary: {employee.Value:f2}");
                    Console.WriteLine(new string('=', 20));
                }
            }
            else
            {
                foreach (KeyValuePair<string, string> employee in position)
                {
                    Console.WriteLine($"Name: {employee.Key}");
                    Console.WriteLine($"Position: {employee.Value}");
                    Console.WriteLine(new string('=', 20));
                }
            }
        }
    }
}
