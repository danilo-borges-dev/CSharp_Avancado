using System;

namespace ByteBank_Unidade_02
{
    internal static class ToWithDraw 
    {
        public static bool WidthDraw(CurrentAccount accoubtReferente, double value)
        {
            if (value <= accoubtReferente.GetBalance() && value > 0)
            {
                double valueInAccountClient = accoubtReferente.GetBalance();
                valueInAccountClient -= value;
                accoubtReferente.SetBalance(valueInAccountClient);
                Console.WriteLine("Operação realizada com Sucesso!");
                Console.WriteLine("Valor atualizado: R$" + accoubtReferente.GetBalance());
                return true;
            }
            Console.WriteLine("Operação inválida ou saldo insuficiente!");
            return false;
        }
    }
}
