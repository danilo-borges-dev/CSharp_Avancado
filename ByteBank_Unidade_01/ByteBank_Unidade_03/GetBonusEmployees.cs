using ByteBank_Unidade_03.Funcionarios;
using System;

namespace ByteBank_Unidade_03
{
    internal class GetBonusEmployees
    {
        private static double _totalBonusEmployees;
        public double TotalBonusEmplyees { get { return _totalBonusEmployees; } }

        public virtual string GetBonus(Employee emplyee)
        {
            var bonusValue = emplyee.TotalWage * emplyee.Bonus;
            _totalBonusEmployees += bonusValue;
            var bonusemployee = emplyee.TotalWage + bonusValue;
            emplyee.SetWage(bonusemployee);
            Console.WriteLine($"\nValor da Bonificação R${bonusValue.ToString("F1")}");
            Console.Write($"Valor do Salário atualizado R${emplyee.GetWage()}\n");
            return "Bonus adicionado com sucesso!\n";
        }
    }
}
