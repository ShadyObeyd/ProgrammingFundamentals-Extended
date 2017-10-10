using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MixedPhones
{
    class MixedPhones
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, long> phonebook = new SortedDictionary<string, long>();

            string[] input = Console.ReadLine().Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);
            

            while (input[0] != "Over")
            {
                string firstelement = input[0];
                string secondElement = input[1];
            
                long number;
            
                if (long.TryParse(firstelement, out number))
                {
                    phonebook[secondElement] = number;
                }
                else
                {
                    phonebook[firstelement] = long.Parse(secondElement);
                }
            
            
                input = Console.ReadLine().Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);
            }
            
            foreach (KeyValuePair<string, long> item in phonebook)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
