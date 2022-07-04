using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Danilo", "Rosana", "Marcos" };
            string[] names_02 = { "Sueli", "João", "Ysabella", "Nayla" };

            string[] allNames = names + names_02;

        }

        public class HouseName
        {
            string[] N1 = new string[2];
            string[] N2 = new string[3];

            public static HouseName operator +(string[] names_01, string[] names_02)
            {
                string nw = new string[];
                foreach (string n in names_01)
                {
                    nw.Add
                }
            }
        }
    }
}