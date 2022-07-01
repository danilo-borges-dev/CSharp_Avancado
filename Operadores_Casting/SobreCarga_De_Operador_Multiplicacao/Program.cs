using System;

namespace SobreCarga_De_Operador_Multiplicacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Multiplicacao op1 = new Multiplicacao(2, 2);
            Multiplicacao op2 = new Multiplicacao(3, 2);
            var result = op1 * op2;

            Console.WriteLine(result);

            Console.ReadLine();
        }

        public class Multiplicacao
        {
            public int Numerador { get; set; }
            public int Denominador { get; set; }
            public int Result
            {
                get
                {
                    return Numerador + Denominador;
                }
            }
            public Multiplicacao(int numerador, int denominador)
            {
                Numerador = numerador;
                Denominador = denominador;
            }

            public override string ToString()
            {
                return String.Format("Resultado da multiplicação: {0:d}", Result);
            }

            public static Multiplicacao operator *(Multiplicacao m1, Multiplicacao m2) // m1 e m2 São variáveis que estão armazenando a referência dos dois objetos Multiplicação 
                // para que possamos acessá-los depois
                // Aqui estamos sobrecarregando o operador + que está sendo utilizando na property Result
                // Agora o operador de * dentro da class Multiplicacao irá realizar mais do que simplemente mutiplicar dois valores, agora irá realizar a operação de adição dos elementos
                // e multiplicação.
                // Estes elementos são passados por parâmetro na instanciação da classe Multiplicação
            {
                Multiplicacao m = new Multiplicacao(m1.Numerador + m1.Denominador, m2.Numerador + m2.Denominador);
                return m;// Neste ponto instanciamos um novo Objeto Mutliplicação que vai atualizar 
                // os valores das propriedades Numerador e Denominador
            }

            public static Multiplicacao operator *(Multiplicacao m1, int n1)
            {
                return new Multiplicacao(m1.Denominador * n1, m1.Denominador);
            }
        }
    }
}
