using System;

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

            var valorVar = 1200;  // Aqui temos uma variável de Tipo Valor, ou seja, ela é responsável e esta armazenando um valor 1200
            var referenceVar = clientDanilo;  // Aqui temos uma variável de Tipo Referência, ou seja, é responsável por aramazenar a referência de um objeto
            object referenceObj = clientDanilo;  // Aqui temos outra variável que armazena uma referência, porém agora está Tipada

            if (referenceVar == referenceObj)
            {
                Console.WriteLine("Sim, referenceVar está armazenando a mesma referencia de referenceObj.");
            }
            else
            {
                Console.WriteLine("Não, as variáveis possuiem valor ou referencia diferentes!");
            }



            Console.ReadKey();
        }        
    }
}
