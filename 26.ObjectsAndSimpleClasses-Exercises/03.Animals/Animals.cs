using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animals
{
    class Animals
    {
        static void Main()
        {
            string input = Console.ReadLine();

            List<Dog> dogs = new List<Dog>();
            List<Cat> cats = new List<Cat>();
            List<Snake> snakes = new List<Snake>();

            while (input != "I'm your Huckleberry")
            {
                string[] tokens = input.Split(' ');

                if (tokens[0] == "talk")
                {
                    foreach (Dog dog in dogs)
                    {
                        if (dog.DogName == tokens[1])
                        {
                            ProduceSoundDog();
                        }
                    }
                    foreach (Cat cat in cats)
                    {
                        if (cat.CatName == tokens[1])
                        {
                            ProduceSoundCat();
                        }
                    }
                    foreach (Snake snake in snakes)
                    {
                        if (snake.SnakeName == tokens[1])
                        {
                            ProduceSoundSnake();
                        }
                    }
                }
                else
                {
                    string animalType = tokens[0];
                    string animalName = tokens[1];
                    int animalAge = int.Parse(tokens[2]);

                    if (animalType == "Dog")
                    {
                        Dog dog = new Dog
                        {
                            DogName = animalName,
                            DogAge = animalAge,
                            LegsCount = int.Parse(tokens[3])
                        };
                        dogs.Add(dog);
                    }
                    else if (animalType == "Cat")
                    {
                        Cat cat = new Cat
                        {
                            CatName = animalName,
                            CatAge = animalAge,
                            IQ = int.Parse(tokens[3])
                        };
                        cats.Add(cat);
                    }
                    else if (animalType == "Snake")
                    {
                        Snake snake = new Snake
                        {
                            SnakeName = animalName,
                            SnakeAge = animalAge,
                            CrueltyCoeficient = int.Parse(tokens[3])
                        };
                        snakes.Add(snake);
                    }
                }
                input = Console.ReadLine();
            }

            foreach (Dog dog in dogs)
            {
                string dogName = dog.DogName;
                int dogAge = dog.DogAge;
                int legsCount = dog.LegsCount;

                Console.WriteLine($"Dog: {dogName}, Age: {dogAge}, Number Of Legs: {legsCount}");
            }
            foreach (Cat cat in cats)
            {
                string catName = cat.CatName;
                int catAge = cat.CatAge;
                int iq = cat.IQ;

                Console.WriteLine($"Cat: {catName}, Age: {catAge}, IQ: {iq}");
            }
            foreach (Snake snake in snakes)
            {
                string snakeName = snake.SnakeName;
                int snakeAge = snake.SnakeAge;
                int crueltycoef = snake.CrueltyCoeficient;

                Console.WriteLine($"Snake: {snakeName}, Age: {snakeAge}, Cruelty: {crueltycoef}");
            }
        }
        static void ProduceSoundDog()
        {
            Console.WriteLine("I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
        }
        static void ProduceSoundCat()
        {
            Console.WriteLine("I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
        }
        static void ProduceSoundSnake()
        {
            Console.WriteLine("I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
        }
        class Dog
        {
            public string DogName { get; set; }
            public int DogAge { get; set; }
            public int LegsCount { get; set; }
        }
        class Cat
        {
            public string CatName { get; set; }
            public int CatAge { get; set; }
            public int IQ { get; set; }
        }
        class Snake
        {
            public string SnakeName { get; set; }
            public int SnakeAge { get; set; }
            public int CrueltyCoeficient { get; set; }
        }
    }
}
