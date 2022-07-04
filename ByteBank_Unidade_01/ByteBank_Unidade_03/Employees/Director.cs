using ByteBank_Unidade_03.Funcionarios;

namespace ByteBank_Unidade_03.Employees
{
    internal class Director : Employee
    {
        private string _passwordLogin;
        public string PasswordLogin
        {
            get { return _passwordLogin; }
        }
        public Director(string name, string cpf, double wage, string password) : base(name, cpf, wage) 
        {
            _bonus = 0.50;
            _passwordLogin = password;
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
