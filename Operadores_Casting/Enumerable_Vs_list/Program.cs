using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerable_Vs_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var items = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var item = items.GetEnumerator(); // Enumera, define a quantidade de index do array e armazena

            while (item.MoveNext())
            {
                Console.WriteLine(item.Current);
            }

            Console.ReadLine();
        }    
    }
}
