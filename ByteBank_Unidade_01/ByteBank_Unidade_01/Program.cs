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

            var valorVar = 1_200;  // Aqui temos uma variável de Tipo Valor, ou seja, ela é responsável e esta armazenando um valor 1200
            var referenceVar = clientDanilo;  // Aqui temos uma variável de Tipo Referência, ou seja, é responsável por aramazenar a referência de um objeto
            object referenceObj = clientDanilo;  // Aqui temos outra variável que armazena uma referência, porém agora está Tipada

            if (referenceVar == referenceObj)
            {
                Console.WriteLine("Sim, referenceVar está armazenando a mesma referencia de referenceObj.");
            }
            else
            {
                Console.WriteLine("Não, as variáveis possuiem valor ou referencia diferentes!\n");
            }

            Client newClient;  // Aqui temos uma variável do Tipo Client que será utilizada para armazenar a referência do objeto instanciado clientGabriela
            newClient = clientGabriela;

            Console.WriteLine(newClient.GetClientName());

            Console.WriteLine();

            var ternariOperator = ( valorVar == 1200) ? true : false;  // Aqui temos a declaração de um operador ternário, responsável por verificar
                                                                       // se o valor da vairável valorVar é igual a 1200 e aramazenar na variável ternarioOperator true ou false

            Console.WriteLine(ternariOperator);

            Console.WriteLine();

            accountDaGabriela = accountDoDanilo;

            Console.WriteLine(accountDaGabriela.GetNumberAccount());

            Console.ReadKey();
        }        
    }
}
