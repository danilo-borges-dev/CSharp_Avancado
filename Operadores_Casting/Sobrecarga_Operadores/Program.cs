using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga_Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var people1 = new People<string>() { "Danilo", "Marcos" };
            var people2 = new People<string>() { "Rosana", "Nayla" };
            var people3 = people1 + people2;

            people3.ForEach(element => Console.WriteLine(element));

            Console.ReadLine();
        }

        public class People<T> : List<T>
        {
            public static People<T> operator + (People<T> p1, People<T> p2)
            {
                var people = new People<T>();
                p1.ForEach(element => people.Add(element));
                p2.ForEach(element => people.Add(element));
                return people;
            }
        }
    }
}