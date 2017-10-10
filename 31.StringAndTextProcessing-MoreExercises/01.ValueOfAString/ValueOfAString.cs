using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ValueOfAString
{
    class ValueOfAString
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string caseToSum = Console.ReadLine().ToUpper();

            int sum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if ((text[i] >= 97 && text[i] <= 122) && caseToSum == "LOWERCASE")
                {
                    sum += text[i];
                }
                else if ((text[i] >= 65 && text[i] <= 90) && caseToSum == "UPPERCASE")
                {
                    sum += text[i];
                }
            }
            Console.WriteLine($"The total sum is: {sum}");
        }
    }
}
