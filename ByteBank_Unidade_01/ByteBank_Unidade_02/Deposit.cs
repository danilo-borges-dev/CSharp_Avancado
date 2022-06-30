using System;

namespace ByteBank_Unidade_02
{
    internal static class Deposit
    {
        public static bool DepositValueInClientAccount(CurrentAccount clientAccount, double value)
        {
            if (value > 0)
            {
                Console.WriteLine("Depósito realizado com sucesso!");
                clientAccount.SetBalance(value);
                Console.WriteLine($"Valor atualizado: R${clientAccount.GetBalance()}");
                return true;
            }
            Console.WriteLine("Valor inválido!");
            return false;
        }
    }
}
