using ByteBank_Unidade_03.Employees;
using ByteBank_Unidade_03.Funcionarios;
using System;

namespace ByteBank_Unidade_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee funcCarlos = new Employee("Carlos", "111.111.111-11", 5_000);

            Console.WriteLine(funcCarlos.ToString());

            GetBonusEmployees manegerBonus = new GetBonusEmployees();

            Console.WriteLine(manegerBonus.GetBonus(funcCarlos));

            Console.WriteLine();

            Director daniloDiretor = new Director("Danilo Diretor", "111.111.111-11", 5_000);
            Console.WriteLine($"Valor de Bonificação R${daniloDiretor.Bonus * daniloDiretor.TotalWage}");

            Console.WriteLine(manegerBonus.GetBonus(daniloDiretor));

            Console.WriteLine($"\nTotal de Bonificações dos funcionários R${manegerBonus.TotalBonusEmplyyes}");

            Console.ReadLine();
        }
    }
}
