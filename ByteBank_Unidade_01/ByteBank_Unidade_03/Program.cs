using ByteBank_Unidade_03.Employees;
using ByteBank_Unidade_03.InternalSystem;
using System;

namespace ByteBank_Unidade_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            T t = null;

            try
            {
                Console.WriteLine(t.saldo);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Teste()
        {

        }

        public class T
        {
            public int saldo;
        }
    }
}
