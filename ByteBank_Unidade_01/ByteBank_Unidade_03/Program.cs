using ByteBank_Unidade_03.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Unidade_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee funcCarlos = new Employee("Carlos", "111.111.111-11", 5_000);

            Console.WriteLine(funcCarlos.ToString());

            GetBonusEmployees bonus = new GetBonusEmployees();

            Console.WriteLine(bonus.GetBonus(funcCarlos));

            Console.ReadLine();
        }
    }
}
