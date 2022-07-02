using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cast_Customizado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LetraAlfabeto l = new LetraAlfabeto('C');

            char letra = l;

            Console.WriteLine(l);

            Console.ReadLine();
        }

        public class LetraAlfabeto
        {
            char caractere;

            public LetraAlfabeto(char letra)
            {
                caractere = char.ToUpper(letra);
            }

            public static implicit operator char(LetraAlfabeto letra)
            {
                return letra.caractere;
            }
        }
    }
}
