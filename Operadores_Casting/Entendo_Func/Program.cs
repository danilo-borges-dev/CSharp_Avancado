using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entendo_Func
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> somar = Somar;

            int result = Somar(2);

            Console.WriteLine(result);

            Console.ReadLine();
        }

        public static string MensagemDeBomDia()
        {
            return "Bom dia Danilo!";
        }

        public static int Somar(int x)
        {
            return x + 2;
        }
    }
}
