using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class TrickyStrings
{
    static void Main(string[] args)
    {
        string delimiter = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());

        string result = string.Empty;

        for (int i = 0; i < n - 1; i++)
        {
            string strings = Console.ReadLine();
            result += strings + delimiter;
        }
        string lastString = Console.ReadLine();
        Console.WriteLine(result + lastString);
        
    }
}
