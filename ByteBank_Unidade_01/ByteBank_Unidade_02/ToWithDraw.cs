using System;

namespace ByteBank_Unidade_02
{
    internal static class ToWithDraw 
    {
        public static bool WidthDraw(CurrentAccount accoubtReferente, double value)
        {
            if (value <= accoubtReferente.GetTotalCurrenteAccountBank() && value > 0)
            {
                accoubtReferente.SetBalance(value);
                Console.WriteLine("Operação realizada com Sucesso!");
                Console.WriteLine("Valor atualizado: R$" + accoubtReferente.GetBalance());
                return true;
            }
            Console.WriteLine("Operação inválida ou saldo insuficiente!");
            return false;
        }
    }
}
