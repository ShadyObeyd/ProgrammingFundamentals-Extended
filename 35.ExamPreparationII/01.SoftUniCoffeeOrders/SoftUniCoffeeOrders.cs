using System;
using System.Globalization;

namespace _01.SoftUniCoffeeOrders
{
    class SoftUniCoffeeOrders
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            decimal totalSum = 0;

            for (int i = 0; i < n; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                long capsulesCount = long.Parse(Console.ReadLine());

                int daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);

                decimal price = ((decimal)daysInMonth * (decimal)capsulesCount) * (decimal)pricePerCapsule;

                Console.WriteLine($"The price for the coffee is: ${price:f2}");

                totalSum += price;
            }
            Console.WriteLine($"Total: ${totalSum:f2}");
        }
    }
}
