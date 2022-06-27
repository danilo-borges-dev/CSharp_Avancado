using System;
using System.Collections.Generic;

namespace Delegates
{
    internal class Program
    {
        public delegate int OperacoesMatematicas(int x, int y);

        public static int Somar (int x, int y)
        {
            Console.WriteLine($"A soma entre {x} + {y} = {x + y}");
            return x + y;
        }

        public static int Subtratir(int x, int y)
        {
            Console.WriteLine($"A subtração {x} - {y} = {x - y}");
            return x - y;
        }

        public static int Mutiplicacao (int x, int y)
        {
            Console.WriteLine($"A mutiplicação de {x} * {y} = {x * y}");
            return x * y;
        }

        static void Main(string[] args)
        {
            List<OperacoesMatematicas> operacoesM = new List<OperacoesMatematicas>();
            operacoesM.Add(Somar);
            operacoesM.Add(Subtratir);
            operacoesM.Add(Mutiplicacao);

            foreach (var item in operacoesM)
            {
                item(12, 5);
            }


            Console.ReadLine();
        }
    }
}
