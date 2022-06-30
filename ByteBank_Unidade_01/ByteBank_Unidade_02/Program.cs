using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Unidade_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CurrentAccount accountDeDanilo = new CurrentAccount();
            Client clientDaniloBorges = new Client("Danilo Borges", 01, 26, 'M', accountDeDanilo);
            accountDeDanilo.SetBalance(100);

            Console.WriteLine(ToWithDraw.WidthDraw(accountDeDanilo, 100));

            Deposit.DepositValueInClientAccount(accountDeDanilo, 1285_000);

            Console.WriteLine();

            CurrentAccount accountDeJoao = new CurrentAccount();
            Client clientJoao = new Client("João Silva", 01, 26, 'M', accountDeDanilo);

            TransferValueTheClientAccountToOtherClientAccount.Transfer(accountDeDanilo, 50, accountDeJoao);

            Console.ReadLine();
        }
    }
}
