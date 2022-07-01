using System;

namespace SobreCarga_De_Operador_Maior_Que_E_Menor_Que
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.ReadLine();
        }

        public class Sobrecarga
        {
            public int Numerador { get; set; }
            public int Denominador { get; set; }

            public int Resultado
            {
                get { return Denominador + Numerador; }
            }

            public Sobrecarga(int numerador, int denominador)
            {
                Numerador = numerador;
                Denominador = denominador;
            }

            public override string ToString()
            {
                string msg = $"Resultado da operação {Resultado}";
                return msg.ToString();
            }

            public static bool operator <(Sobrecarga s1, Sobrecarga s2)
            {
                return s1.Denominador < s2.Denominador;
            }

            public static bool operator >(Sobrecarga s1, Sobrecarga s2)
            {
                return ((s1.Denominador + s1.Numerador) > (s2.Denominador + s2.Numerador));
            }
        }
    }
}
