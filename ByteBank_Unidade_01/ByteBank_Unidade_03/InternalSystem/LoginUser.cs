using ByteBank_Unidade_03.Employees;

namespace ByteBank_Unidade_03.InternalSystem
{
    internal class LoginUser : IValidateLogin
    {
        public bool Validate(Director employee, string password)
        {
            if (employee.PasswordLogin == password)
            {
                System.Console.WriteLine("Login Autorizado ao Sistema!");
                return true;
            }
            System.Console.WriteLine("Login não Autorizado! Senha incorreta!");
            return false;
        }
    }
}
