using System;
using System.Collections.Generic;

namespace Sobrecarga_Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // A seguir temos duas listas de pessoas

            var people1 = new People<string>() { "Danilo", "Marcos", "Rosana" };  // Primeira lista
            var people2 = new People<string>() { "João", "Nayla", "Ysabella" };  // Segunda lista
            var result = people1 + people2;  // Aqui precisamos somar, juntar as duas listas

            result.ForEach((people) => Console.WriteLine(people));

            Console.ReadLine();
        }

        public class People<T> : List<T>  // Criamos a classe People que herda da classe List
        {
            public static People<T> operator + (People<T> p1, People<T> p2)  // Aqui temos um método que vai retornar uma lista do "tipo" People. Este método possui dois parâmetros de entrada (duas listas)
            {
                var people = new People<T>();  // Criamos uma nova variável para armazenar a junção das duas listas
                p1.ForEach((element) => people.Add(element));  // O ForEach vai percorrer a primeira lista passada por parâmetro e armazenar na variável people
                p2.ForEach((element) => people.Add(element));  
                return people;  // Retorna a lista atualizada

                // Após o retorno temos que percorrer novamente a lista de pessoas atualizada e exibir no console. Podemos realizar ade algumas formas utilizando um for, foreach ou ForEach funcional, este conforme o exemplom acima
            }
        }
        
    }
}