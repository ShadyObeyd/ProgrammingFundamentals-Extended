using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Exercises
{
    class Exercises
    {
        static void Main()
        {
            string input = Console.ReadLine();

            List<Exercise> storedExercises = new List<Exercise>();

            while (input != "go go go")
            {
                string[] tokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                
                string topic = tokens[0];
                string courseName = tokens[1];
                string judgeLink = tokens[2];
                string[] problems = tokens[3].Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                Exercise exercise = new Exercise
                {
                    Topic = topic,
                    CourseName = courseName,
                    JudgeContestLink = judgeLink,
                    Problems = problems
                };
                storedExercises.Add(exercise);
                input = Console.ReadLine();
            }

            foreach (Exercise exercise in storedExercises)
            {
                Console.WriteLine($"Exercises: {exercise.Topic}");
                Console.WriteLine($"Problems for exercises and homework for the \"{exercise.CourseName}\" course @ SoftUni.");
                Console.WriteLine($"Check your solutions here: {exercise.JudgeContestLink}");
                int cntr = 1;

                foreach (string problem in exercise.Problems)
                {
                    Console.WriteLine($"{cntr}. {problem}");
                    cntr++;
                }
            }
        }
        class Exercise
        {
            public string Topic { get; set; }
            public string CourseName { get; set; }
            public string JudgeContestLink { get; set; }
            public string[] Problems { get; set; }
        }
    }
}
