using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcao_De_Ordem_Superior
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, Func<int, int>, int> fnHigherOrder = (number, fn) =>
            {
                if (number > 100)
                {
                    return fn(number);
                }
                else
                {
                    return 171;
                }
            };

            var res = fnHigherOrder(600, (n) => n * 2);

            Console.ReadLine();
        }
    }
}
