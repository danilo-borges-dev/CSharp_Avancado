using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Unidade_03
{
    internal class CustomException : Exception
    {
        public CustomException(string message)
        {

        }
        private static void TestThrow()
        {
            throw new CustomException("Custom exception in TestThrow()");
        }
    }
}
