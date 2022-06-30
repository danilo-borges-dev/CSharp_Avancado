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

            Console.WriteLine(clientGabriela.GetClientName());

            Console.WriteLine(accountDaGabriela.GetNumberAccount());

            Console.ReadKey();
        }
    }
}
