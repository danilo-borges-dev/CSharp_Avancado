using System.Collections.Generic;
using System.Linq;
using System;

namespace Lambda_Expressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action algoNoConsole = () =>
            {
                Console.WriteLine("Lmabida com C#");
            };

            algoNoConsole();

            Func<int> jogarDado = () =>
            {
                Random random = new Random();
                return random.Next(1, 7);
            };

            Console.WriteLine(jogarDado());

            Console.ReadLine();
        }
    }
}
