using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda_Expressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 5, 6, 7 };
            Action<int> print = (number) => Console.WriteLine(number); // Aqui temos uma instrução Action que vai executar uma empressão Lambda que retorna 
            // no console o valor de parâmetro de entrada

            Action<List<int>> show = (nun) => // Aqui nós temos uma instrução Action chamado show que recebe como parâmetro de entrada uma Lista.
            // A instrução show recebe uma Sentença lambda que vai percorrer a Lista recebida por parâmetro e vai exebir os elementos da Lista atrvés 
            // da instrução Action print
            {
                foreach (var item in numbers)
                {
                    print(item);
                }
            };

            show(numbers);
            Console.ReadLine();

        }

        public static int Mutiplicar(int a)
        {
            return a * 2;
        }
    }
}
