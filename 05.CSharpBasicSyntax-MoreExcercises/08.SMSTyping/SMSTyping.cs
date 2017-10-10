using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SMSTyping
{
    class SMSTyping
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string sms = string.Empty;
            for (int i = 0; i < n; i++)
            {
                int digits = int.Parse(Console.ReadLine());
                if (digits == 0)
                {
                    sms += " ";
                }
                else if (digits == 2)
                {
                    sms += "a";
                }
                else if (digits == 22)
                {
                    sms += "b";
                }
                else if (digits == 222)
                {
                    sms += "c";
                }
                else if (digits == 3)
                {
                    sms += "d";
                }
                else if (digits == 33)
                {
                    sms += "e";
                }
                else if (digits == 333)
                {
                    sms += "f";
                }
                else if (digits == 4)
                {
                    sms += "g";
                }
                else if (digits == 44)
                {
                    sms += "h";
                }
                else if (digits == 444)
                {
                    sms += "i";
                }
                else if (digits == 5)
                {
                    sms += "j";
                }
                else if (digits == 55)
                {
                    sms += "k";
                }
                else if (digits == 555)
                {
                    sms += "l";
                }
                else if (digits == 6)
                {
                    sms += "m";
                }
                else if (digits == 66)
                {
                    sms += "n";
                }
                else if (digits == 666)
                {
                    sms += "o";
                }
                else if (digits == 7)
                {
                    sms += "p";
                }
                else if (digits == 77)
                {
                    sms += "q";
                }
                else if (digits == 777)
                {
                    sms += "r";
                }
                else if (digits == 7777)
                {
                    sms += "s";
                }
                else if (digits == 8)
                {
                    sms += "t";
                }
                else if (digits == 88)
                {
                    sms += "u";
                }
                else if (digits == 888)
                {
                    sms += "v";
                }
                else if (digits == 9)
                {
                    sms += "w";
                }
                else if (digits == 99)
                {
                    sms += "x";
                }
                else if (digits == 999)
                {
                    sms += "y";
                }
                else if (digits == 9999)
                {
                    sms += "z";
                }
            }
            Console.WriteLine(sms);
        }
    }
}
