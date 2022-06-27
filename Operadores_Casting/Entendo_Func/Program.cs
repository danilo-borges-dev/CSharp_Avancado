using System;

namespace Entendo_Func
{
    internal class Program
    {
        // Func possibilita criar uma variável que vai armazenar a execução de um Método.
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
        // A diferença com Delegate é que é possível adicionar apenas UM método.
        // O Delegate que permite adicionar/apontar para vários Métodos e Funções.
    }
}
