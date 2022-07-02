using ByteBank_Unidade_03.Funcionarios;

namespace ByteBank_Unidade_03.Employees
{
    internal class Director : Employee
    {
        public Director(string name, string cpf, double wage) : base(name, cpf, wage) 
        {
            _bonus = 0.50;
        }
        public override string ToString()
        {
            string message = $"\nDiretor: {this._name}\n" +
                             $"CPF: {this._cpf}\n" +
                             $"Salário R${this._wage}\n";
            return message.ToString();
        }

        public override int Teste(int a, int b)
        {
            return b;
        }
    }
}
