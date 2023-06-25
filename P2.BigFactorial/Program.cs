using System;
using System.Numerics;

namespace P2.BigFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int inputNumber = int.Parse(Console.ReadLine());
           BigInteger factorial = 1;

           for (int i = 1; i <= inputNumber; i++)
           {
               factorial *= i;
           }

           Console.WriteLine(factorial);
        }
    }
}
