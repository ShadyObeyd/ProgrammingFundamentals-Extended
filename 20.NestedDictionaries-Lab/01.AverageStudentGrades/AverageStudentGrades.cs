using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.AverageStudentGrades
{
    class AverageStudentGrades
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> studentsData = new Dictionary<string, List<double>>();

            int studentsCntr = int.Parse(Console.ReadLine());

            for (int i = 0; i < studentsCntr; i++)
            {
                string[] student = Console.ReadLine().Split(' ');

                string name = student[0];
                double grade = double.Parse(student[1]);

                if (!studentsData.ContainsKey(name))
                {
                    studentsData.Add(name, new List<double>());
                }
                studentsData[name].Add(grade);
            }

            foreach (KeyValuePair<string, List<double>> studentData in studentsData)
            {
                string name = studentData.Key;
                List<double> grades = studentData.Value;
                double avg = grades.Average();

                Console.Write($"{name} -> ");

                foreach (double grade in grades)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.WriteLine($"(avg: {avg:f2})");
            }
        }
    }
}
