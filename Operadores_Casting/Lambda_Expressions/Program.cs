using System.Collections.Generic;
using System.Linq;
using System;

namespace Lambda_Expressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };

            var listaFiltrada = lista.Where(x => x > 4);

            foreach (var item in listaFiltrada)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        public static bool Filtro(int x)
        {
            return x > 4;
        }
    }
}
