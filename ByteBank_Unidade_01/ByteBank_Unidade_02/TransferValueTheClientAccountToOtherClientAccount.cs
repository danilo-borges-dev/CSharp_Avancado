using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Unidade_02
{
    internal static class TransferValueTheClientAccountToOtherClientAccount
    {
        public static bool Transfer(CurrentAccount accountOrigin, double value, CurrentAccount accountDestiny)
        {
            if (accountOrigin.GetBalance() >= value && value > 0)
            {
                double valueInAccountClient = accountOrigin.GetBalance();
                valueInAccountClient -= value;
                accountOrigin.SetBalance(valueInAccountClient);

                double valueInAccountClientDestiny = accountDestiny.GetBalance();
                valueInAccountClientDestiny += value;
                accountDestiny.SetBalance(valueInAccountClientDestiny);

                Console.WriteLine($@"
 Transferência realizada com sucesso!");
                Console.WriteLine($@"
 Valor atualizado da sua conta R${accountOrigin.GetBalance()}");
                Console.WriteLine($@"
 Transferido para conta de {accountDestiny.GetHolderName()}
 Valor de R${value}");
                return true;
            }
            return false;
        }
    }
}
