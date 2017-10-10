using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.DataOverflow
{
    class DataOverflow
    {
        static void Main(string[] args)
        {
            ulong a = ulong.Parse(Console.ReadLine());
            ulong b = ulong.Parse(Console.ReadLine());

            bool isByteA = a >= byte.MinValue && a <= byte.MaxValue;
            bool isByteB = b >= byte.MinValue && b <= byte.MaxValue;

            bool isUshortA = a >= ushort.MinValue && a <= ushort.MaxValue;
            bool isUshortB = b >= ushort.MinValue && b <= ushort.MaxValue;

            bool isUintA = a >= uint.MinValue && a <= uint.MaxValue;
            bool isUintB = b >= uint.MinValue && b <= uint.MaxValue;

            bool isUlongA = a >= ulong.MinValue && a <= ulong.MaxValue;
            bool isUlongB = b >= ulong.MinValue && b <= ulong.MaxValue;

            if (a >= b)
            {
                if (isByteA && isByteB)
                {
                    Console.WriteLine("bigger type: byte");
                    Console.WriteLine("smaller type: byte");
                    Console.WriteLine($"{a} can overflow byte {Math.Round((decimal)a / byte.MaxValue)} times");
                }
                else if (isUshortA && isByteB)
                {
                    Console.WriteLine("bigger type: ushort");
                    Console.WriteLine("smaller type: byte");
                    Console.WriteLine($"{a} can overflow byte {Math.Round((decimal)a / byte.MaxValue)} times");
                }
                else if (isUintA && isByteB)
                {
                    Console.WriteLine("bigger type: uint");
                    Console.WriteLine("smaller type: byte");
                    Console.WriteLine($"{a} can overflow byte {Math.Round((decimal)a / byte.MaxValue)} times");
                }
                else if (isUintA && isUshortB)
                {
                    Console.WriteLine("bigger type: uint");
                    Console.WriteLine("smaller type: ushort");
                    Console.WriteLine($"{a} can overflow ushort {Math.Round((decimal)a / ushort.MaxValue)} times");
                }
                else if (isUlongA && isByteB)
                {
                    Console.WriteLine("bigger type: ulong");
                    Console.WriteLine("smaller type: byte");
                    Console.WriteLine($"{a} can overflow byte {Math.Round((decimal)a / byte.MaxValue)} times");
                }
                else if (isUlongA && isUshortB)
                {
                    Console.WriteLine("bigger type: ulong");
                    Console.WriteLine("smaller type: ushort");
                    Console.WriteLine($"{a} can overflow ushort {Math.Round((decimal)a / ushort.MaxValue)} times");
                }
                else if (isUlongA && isUintB)
                {
                    Console.WriteLine("bigger type: ulong");
                    Console.WriteLine("smaller type: uint");
                    Console.WriteLine($"{a} can overflow uint {Math.Round((decimal)a / uint.MaxValue)} times");
                }
                else if (isUlongA && isUlongB)
                {
                    Console.WriteLine("bigger type: ulong");
                    Console.WriteLine("smaller type: ulong");
                    Console.WriteLine($"{a} can overflow ulong {Math.Round((decimal)a / ulong.MaxValue)} times");
                }
            }
            else if (b >= a)
            {
                if (isByteB && isByteA)
                {
                    Console.WriteLine("bigger type: byte");
                    Console.WriteLine("smaller type: byte");
                    Console.WriteLine($"{b} can overflow byte {Math.Round((decimal)b / byte.MaxValue)} times");
                }
                else if (isUshortB && isByteA)
                {
                    Console.WriteLine("bigger type: ushort");
                    Console.WriteLine("smaller type: byte");
                    Console.WriteLine($"{b} can overflow byte {Math.Round((decimal)b / byte.MaxValue)} times");
                }
                else if (isUintB && isByteA)
                {
                    Console.WriteLine("bigger type: uint");
                    Console.WriteLine("smaller type: byte");
                    Console.WriteLine($"{b} can overflow byte {Math.Round((decimal)b / byte.MaxValue)} times");
                }
                else if (isUintB && isUshortA)
                {
                    Console.WriteLine("bigger type: uint");
                    Console.WriteLine("smaller type: ushort");
                    Console.WriteLine($"{b} can overflow ushort {Math.Round((decimal)b / ushort.MaxValue)} times");
                }
                else if (isUlongB && isByteA)
                {
                    Console.WriteLine("bigger type: ulong");
                    Console.WriteLine("smaller type: byte");
                    Console.WriteLine($"{b} can overflow byte {Math.Round((decimal)b / byte.MaxValue)} times");
                }
                else if (isUlongB && isUshortA)
                {
                    Console.WriteLine("bigger type: ulong");
                    Console.WriteLine("smaller type: ushort");
                    Console.WriteLine($"{b} can overflow ushort {Math.Round((decimal)b / ushort.MaxValue)} times");
                }
                else if (isUlongB && isUintA)
                {
                    Console.WriteLine("bigger type: ulong");
                    Console.WriteLine("smaller type: uint");
                    Console.WriteLine($"{b} can overflow uint {Math.Round((decimal)b / uint.MaxValue)} times");
                }
                else if (isUlongB && isUlongA)
                {
                    Console.WriteLine("bigger type: ulong");
                    Console.WriteLine("smaller type: ulong");
                    Console.WriteLine($"{b} can overflow ulong {Math.Round((decimal)b / ulong.MaxValue)} times");
                }
            }
        }

    }
}

