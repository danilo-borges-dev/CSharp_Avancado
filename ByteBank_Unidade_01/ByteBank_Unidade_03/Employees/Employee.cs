using System;

namespace ByteBank_Unidade_03.Funcionarios
{
    internal class Employee
    {
        protected string _name;
        protected string _cpf;
        protected double _wage;
        protected double _bonus = 0.1;
        protected static int _totalEmployees;
        

        public int TotalEmployees { get { return _totalEmployees;  }  }
        public double TotalWage { get { return _wage; } }
        public double Bonus { get { return _bonus; } }

        public Employee(string name, string cpf, double wage)
        {
            if (wage < 0)
            {
                string ex = "Valor de Slário inválido!";
                throw new Exception(ex);
            }

            _name = name;
            _cpf = cpf;
            _wage = wage;
            _totalEmployees++;
        }

        public void SetWage(double value) => _wage += value;
        public double GetWage() => _wage;

        public override string ToString()
        {
            string message = $"\nFuncionário: {this._name}\n" +
                             $"CPF: {this._cpf}\n" +
                             $"Salário R${this._wage}\n";            
            return message.ToString();
        }
    }
}
