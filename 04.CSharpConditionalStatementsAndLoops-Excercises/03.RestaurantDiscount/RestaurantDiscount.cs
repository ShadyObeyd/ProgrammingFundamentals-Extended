using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RestaurantDiscount
{
    class RestaurantDiscount
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string packageType = Console.ReadLine();

            if (groupSize <= 50)
            {
                if (packageType == "Normal")
                {
                    double totalPrice = (2500.0 + 500.0) - ((2500.0 + 500.0) * 0.05);
                    double pricePerPerson = totalPrice / groupSize;
                    Console.WriteLine($"We can offer you the Small Hall \nThe price per person is {pricePerPerson:f2}$");
                }
                else if (packageType == "Gold")
                {
                    double totalPrice = (2500.0 + 750.0) - ((2500.0 + 750.0) * 0.1);
                    double pricePerPerson = totalPrice / groupSize;
                    Console.WriteLine($"We can offer you the Small Hall \nThe price per person is {pricePerPerson:f2}$");
                }
                else if (packageType == "Platinum")
                {
                    double totalPrice = (2500.0 + 1000.0) - ((2500.0 + 1000.0) * 0.15);
                    double pricePerPerson = totalPrice / groupSize;
                    Console.WriteLine($"We can offer you the Small Hall \nThe price per person is {pricePerPerson:f2}$");
                }
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                if (packageType == "Normal")
                {
                    double totalPrice = (5000.0 + 500.0) - ((5000.0 + 500.0) * 0.05);
                    double pricePerPerson = totalPrice / groupSize;
                    Console.WriteLine($"We can offer you the Terrace \nThe price per person is {pricePerPerson:f2}$");
                }
                else if (packageType == "Gold")
                {
                    double totalPrice = (5000.0 + 750.0) - ((5000.0 + 750.0) * 0.1);
                    double pricePerPerson = totalPrice / groupSize;
                    Console.WriteLine($"We can offer you the Terrace \nThe price per person is {pricePerPerson:f2}$");
                }
                else if (packageType == "Platinum")
                {
                    double totalPrice = (5000.0 + 1000.0) - ((5000.0 + 1000.0) * 0.15);
                    double pricePerPerson = totalPrice / groupSize;
                    Console.WriteLine($"We can offer you the Terrace \nThe price per person is {pricePerPerson:f2}$");
                }
            }
            else if (groupSize <= 120)
            {
                if (packageType == "Normal")
                {
                    double totalPrice = (7500.0 + 500.0) - ((7500.0 + 500.0) * 0.05);
                    double pricePerPerson = totalPrice / groupSize;
                    Console.WriteLine($"We can offer you the Great Hall \nThe price per person is {pricePerPerson:f2}$");
                }
                else if (packageType == "Gold")
                {
                    double totalPrice = (7500.0 + 750.0) - ((7500.0 + 750.0) * 0.1);
                    double pricePerPerson = totalPrice / groupSize;
                    Console.WriteLine($"We can offer you the Great Hall \nThe price per person is {pricePerPerson:f2}$");
                }
                else if (packageType == "Platinum")
                {
                    double totalPrice = (7500.0 + 1000.0) - ((7500.0 + 1000.0) * 0.15);
                    double pricePerPerson = totalPrice / groupSize;
                    Console.WriteLine($"We can offer you the Great Hall \nThe price per person is {pricePerPerson:f2}$");
                }
            }
            else if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            
        }
    }
}
