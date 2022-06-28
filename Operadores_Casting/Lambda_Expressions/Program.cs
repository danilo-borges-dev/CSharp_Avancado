using System;

namespace Lambda_Expressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int, int> result = (elementA, elementB, elementC) =>
            {
                if (elementA > elementB && elementA > elementC)
                {
                    return elementA;
                }

                if (elementB > elementA && elementB > elementC)
                {
                    return elementB;
                }
                return elementC;
            };

            Console.WriteLine(result(1, 2, 3));

            Console.ReadLine();

        }

        public static int Mutiplicar(int a)
        {
            return a * 2;
        }
    }
}
