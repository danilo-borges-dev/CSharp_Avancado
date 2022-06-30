using System;
using System.Linq;

namespace ByteBank_Unidade_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client clientGabriela = new Client("Gabriela", 00001, 26, 'F');
            CurrentAccount accountDaGabriela = new CurrentAccount(clientGabriela, 1010, 10101, 100.00);
            ClientDataBase.AddNewClientEnDataBase(clientGabriela, accountDaGabriela);
             
            Console.WriteLine(clientGabriela.GetClientName());  // Exibe no Console o nome do CLiente

            Console.WriteLine(accountDaGabriela.GetNumberAccount());

            Console.WriteLine(accountDaGabriela.ToString()); // Sobrecarrei o método ToString para retornar as informações do Cliente

            Client clientDanilo = new Client("Danilo", 00002, 29, 'M');
            CurrentAccount accountDoDanilo = new CurrentAccount(clientDanilo, 1010, 10102, 789_000.00);
            ClientDataBase.AddNewClientEnDataBase(clientDanilo, accountDoDanilo);

            Console.WriteLine(accountDoDanilo.ToString());

            Console.ReadKey();
        }        
    }
}
