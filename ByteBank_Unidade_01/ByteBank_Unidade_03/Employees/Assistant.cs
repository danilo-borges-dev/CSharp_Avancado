using ByteBank_Unidade_03.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Unidade_03
{
    internal class Assistant : Employee
    {
        public Assistant(string name, string cpf, double wage) : base(name, cpf, wage)
        {
            _bonus = 0.20;
        }
    }
}
