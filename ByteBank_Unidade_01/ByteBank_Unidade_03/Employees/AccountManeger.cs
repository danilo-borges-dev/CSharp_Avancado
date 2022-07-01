using ByteBank_Unidade_03.Funcionarios;

namespace ByteBank_Unidade_03.Employees
{
    internal class AccountManeger : Employee
    {
        public AccountManeger(string name, string cpf, double wage) : base(name, cpf, wage)
        {
            _bonus = 0.25;
        }
    }
}
