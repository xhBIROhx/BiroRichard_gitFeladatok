using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.ConstrainedExecution;

namespace MyApp
{
    internal class Program
    {
        static Random rand;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void F01(int[] tomb) {
            for (int i = 0; i < tomb.Length; i++)
            {   
                tomb[i] += rand.Next(1,51);
            }
        }
    }
}