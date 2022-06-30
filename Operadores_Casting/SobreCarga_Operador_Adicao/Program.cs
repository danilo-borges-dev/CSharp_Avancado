using System;

namespace SobreCarga_Operador_Adicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operacao op1 = new Operacao(2, 3);
            Operacao op2 = new Operacao(2, 3);

            var result = op1 + op2;

            Console.WriteLine(result);

            Console.ReadLine();
        }

    }
    public class Operacao
    {
        public int Numerador { get; set; }
        public int Denominador { get; set; }
        public double Resultador
        {
            get
            {
                return (double)Numerador / Denominador;
            }
        }

        public Operacao(int numerador, int denominador)
        {
            Numerador = numerador;
            Denominador = denominador;
        }

        public override string ToString()
        {
            return String.Format("{0:d}/{1:d}", Numerador, Denominador);
        }
        public static Operacao operator +(Operacao p1, Operacao p2) // Método de Sobrecarga do Operador +
        {

            return new Operacao(p1.Numerador * p2.Numerador, p1.Denominador * p2.Denominador);
        }
    }

}
