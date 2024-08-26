using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class MyMath
    {
        public static int calc_ggt(int a, int b)
        {
            int z = 0;
            while (b != 0)
            {
                z = a % b;
                a = b;
                b = z;
            }
            return a;

        }
        public static int calc_kgv(int a, int b)
        {
            return a * b / calc_ggt(a, b);

        }

        public static int read_int(int a)
        {
            Console.WriteLine("Please enter a number: ");
            string s = Console.ReadLine();
            int.TryParse(s, out a);
            return a;
        }
    }
}



int[] ints = { 200, 450, 700, 175, 250 }{
Console.WriteLine(ints.Sum);}