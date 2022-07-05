using ByteBank_Unidade_03.Employees;
using ByteBank_Unidade_03.InternalSystem;
using System;

namespace ByteBank_Unidade_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person p = new Person("111.111.111-11", 0);
            }
            catch (DontExistEployeeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
