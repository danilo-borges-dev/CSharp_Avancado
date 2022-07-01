using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperaturas temp = new Temperaturas();
            temp[1] = 11;
            int t = temp[1];

            Console.WriteLine(t);

            Console.ReadLine();
        }

        class Temperaturas
        {
            int[] temperaturasDoAno = new int[] { 30, 31, 29, 27, 22, 16, 19, 23, 26, 27, 28 };

            public int this [int mes]
            {
                get
                {
                    return temperaturasDoAno[mes - 1];
                }
                set
                {
                    temperaturasDoAno[mes - 1] = value;
                }
            }
        }
    }
}
