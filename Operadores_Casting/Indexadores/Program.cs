using System;

namespace Indexadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperaturas_02 temp = new Temperaturas_02();
            /*temp[1] = 11;
            int t = temp[1];*/

            Console.WriteLine(temp["Jan"]);

            Console.ReadLine();
        }

        class Temperaturas
        {
            int[] temperaturasDoAno = new int[] { 30, 31, 29, 27, 22, 16, 19, 23, 26, 27, 28 };

            public int this[int mes]
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

        class Temperaturas_02
        {
            int[] temperaturasDoAno = new int[] { 30, 31, 29, 27, 22, 16, 19, 23, 26, 27, 28, 31 };
            public int this[string mes]
            {
                get
                {
                    switch (mes) 
                    {
                        case "Jan": return temperaturasDoAno[0];
                        case "Fev": return temperaturasDoAno[1];
                        case "Mar": return temperaturasDoAno[2];
                        case "Abr": return temperaturasDoAno[3];
                        case "Mai": return temperaturasDoAno[4];
                        case "Jun": return temperaturasDoAno[5];
                        case "Jlh": return temperaturasDoAno[6];
                        case "Ago": return temperaturasDoAno[7];
                        case "Set": return temperaturasDoAno[8];
                        case "Out": return temperaturasDoAno[9];
                        case "Nov": return temperaturasDoAno[10];
                        case "Dez": return temperaturasDoAno[11];
                        default: return -1;
                    }
                }
            }
        }
    }
}
