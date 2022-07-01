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

            Console.WriteLine(IncreaseSalary.IncreaseSalaryEmployee(funcCarlos, 0.15));

            Console.ReadKey();
        }
    }
}
