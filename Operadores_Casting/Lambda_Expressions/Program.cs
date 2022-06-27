using System.Collections.Generic;
using System.Linq;
using System;

namespace Lambda_Expressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> namesList = new List<string>() { "Danilo", "Sueli", "João Borges", "Marcos", "Rosana", "Nayla", "Ysabela"};

            Action<string> names = (name) => Console.WriteLine(name);

            foreach (var item in namesList)
            {
                names(item);
            }

            Console.ReadLine();

        }

        public static int Mutiplicar(int a)
        {
            return a * 2;
        }
    }
}
