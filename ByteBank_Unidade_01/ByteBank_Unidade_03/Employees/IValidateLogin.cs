using ByteBank_Unidade_03.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Unidade_03.Employees
{
    internal interface IValidateLogin
    {
        bool Validate(Director employee, string password);
    }
}
