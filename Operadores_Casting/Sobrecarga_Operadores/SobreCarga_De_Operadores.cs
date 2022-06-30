using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga_Operadores
{
    internal class SobreCarga_De_Operadores
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
        public SobreCarga_De_Operadores(int numerador, int denominador)
        {
            Numerador = numerador;
            Denominador = denominador;
        }

        public override string ToString()
        {
            return String.Format("{0:d}/{1:d}", Numerador, Denominador);
        }
    }
}
