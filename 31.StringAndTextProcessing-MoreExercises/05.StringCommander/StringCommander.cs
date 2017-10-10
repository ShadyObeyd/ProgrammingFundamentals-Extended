using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.StringCommander
{
    class StringCommander
    {
        static void Main()
        {
            string stringToProcess = Console.ReadLine();
            string command = Console.ReadLine();
            
            while (command != "end")
            {
                string[] commandTokens = command.Split(' ');
            
                switch (commandTokens[0])
                {
                    case "Left":
                        int leftCount = int.Parse(commandTokens[1]);
                        leftCount = leftCount % stringToProcess.Length;
                        stringToProcess = 
                            stringToProcess
                            .Substring(leftCount) + stringToProcess.Substring(0, leftCount);
                        break;
            
                    case "Right":
                        int rightCount = int.Parse(commandTokens[1]);
                        rightCount = rightCount % stringToProcess.Length;
                        stringToProcess = 
                            stringToProcess
                            .Substring(stringToProcess.Length - rightCount) + stringToProcess.Substring(0, stringToProcess.Length - rightCount);
                        break;
            
                    case "Insert":
                        int index = int.Parse(commandTokens[1]);
                        string toInsert = commandTokens[2];
                        stringToProcess = stringToProcess.Insert(index, toInsert);
                        break;
                        
                    case "Delete":
                        int startIndex = int.Parse(commandTokens[1]);
                        int endIndex = int.Parse(commandTokens[2]);
                        stringToProcess = stringToProcess.Remove(startIndex, endIndex - startIndex + 1);
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(stringToProcess);
        }
    }
}