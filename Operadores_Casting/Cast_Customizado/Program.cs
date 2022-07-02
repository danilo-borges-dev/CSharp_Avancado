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
            Nome n = new Nome("Danilo");

            string nome = n;

            Console.WriteLine(nome);

            Console.ReadLine();
        }

        public class Nome
        {
            private string _nome;

            public Nome(string nome)
            {
                _nome = nome;
            }

            public static implicit operator string(Nome n)
            {
                return n._nome;
            }
        }
    }
}
