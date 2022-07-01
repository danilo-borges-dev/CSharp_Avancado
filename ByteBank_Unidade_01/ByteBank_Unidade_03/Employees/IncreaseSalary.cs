using ByteBank_Unidade_03.Funcionarios;

namespace ByteBank_Unidade_03.Employees
{
    internal static class IncreaseSalary
    {
        private static double _salary = 0;
        private static double _totalIncrease = 0;

        public static string IncreaseSalaryEmployee(Employee employee, double valuePercantIncreaseSalary)
        {
            if (valuePercantIncreaseSalary > 0)
            {
                double employeeSalary = employee.TotalWage;
                _totalIncrease = employeeSalary * valuePercantIncreaseSalary;
                _salary = employeeSalary + _totalIncrease;
                employee.SetWage(_salary);
                return $"Operação de aumento de Salário realizado com sucesso!\nSalário atualizado R${_salary}";
            }
            return $"Valor {valuePercantIncreaseSalary} inválido!";
        }
    }
}
