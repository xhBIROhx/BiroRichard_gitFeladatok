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
        static int F02(int[] tomb) {
            int szam = 0;
            for (int i = 0; i < tomb.Length; i++)
            {   
                if ( tomb[i] % 2 == 0) {
                    szam ++;
                }
            }
            return szam;
        }

        static double F03(int[] tomb) {
            double atlag = 0;
            for (int i = 0; i < tomb.Length; i++)
            {   
                atlag += tomb[i];
            }
            atlag /= tomb.Length;
            return atlag;
        }

        static int[] F04(int[] tomb) {
            int[] szam = new int[10];
            for (int i = 0; i < tomb.Length; i++)
            {   
                if ( tomb[i] % 2 == 0) {
                    szam[i] = tomb[i]+1;
                }else{
                    szam[i] = tomb[i];
                }
            }
            return szam;
        }
    }
}