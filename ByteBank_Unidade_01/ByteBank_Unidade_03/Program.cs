using ByteBank_Unidade_03.Employees;
using ByteBank_Unidade_03.InternalSystem;
using System;

namespace ByteBank_Unidade_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int denominator = 0;
            int numerator = 2;
            try
            {
                try
                {
                    int result = numerator / denominator;
                }
                catch (DivideByZeroException ex)
                {
                    throw new DivideByZeroException(ex.Message);
                }

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadLine();
        }

    }
}
