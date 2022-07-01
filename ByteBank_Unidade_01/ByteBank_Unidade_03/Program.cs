using ByteBank_Unidade_03.Employees;
using ByteBank_Unidade_03.Funcionarios;
using System;

namespace ByteBank_Unidade_03
{
    internal class Program
    {
        static void Main(string[] args)  // Método Estático, portanto pode receber apenas métodos também estáticos
        {
            Director funcCarlos = new Director("Carlos", "111.111.111-11", 5_000);

            Console.WriteLine(funcCarlos.ToString());

            GetBonusEmployees manegerBonus = new GetBonusEmployees();

            Console.WriteLine(manegerBonus.GetBonus(funcCarlos));

            Console.WriteLine(IncreaseSalary.IncreaseSalaryEmployee(funcCarlos, 0.15));

            GetBonusEmployees bonusManeger = new GetBonusEmployees();
            Console.WriteLine($"\nTotal de Bonificações para os Funcionários R${bonusManeger.TotalBonusEmplyees}");


            Program pg = new Program();
            pg.Teste();
            
            Console.ReadKey();
        }

        public void Teste()
        {
            Console.WriteLine("Dentro do método não estátito!");
        }
    }
}
