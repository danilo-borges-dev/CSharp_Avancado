using System.Collections.Generic;
using System.Linq;
using System;

namespace Lambda_Expressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> sum = (elementA, elementB) => elementA + elementB;

            var r = sum(2,2);

            Console.WriteLine(r);

            Console.ReadLine();

        }

        public static int Mutiplicar(int a)
        {
            return a * 2;
        }
    }
}
