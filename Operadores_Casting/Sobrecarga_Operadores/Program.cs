using System;
using System.Collections.Generic;

namespace Sobrecarga_Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var people1 = new People<string>() { "Danilo", "João"};
            var people2 = new People<string>() { "Marcos", "Rosana" };
            var result = people1 + people2;

            result.ForEach(element => Console.WriteLine(element));

            Console.ReadLine();
        }  
        
        public class  People<T> : List<T>
        {
            public static People<T> operator +(People<T> p1, People<T> p2)
            {
                var people = new People<T>();
                p1.ForEach(element => people.Add(element));
                p1.ForEach(element => people.Add(element));
                return people;
            }
        }
    }
}