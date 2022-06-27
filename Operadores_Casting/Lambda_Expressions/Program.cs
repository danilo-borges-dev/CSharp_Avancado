using System.Collections.Generic;
using System.Linq;
using System;

namespace Lambda_Expressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> b = (a) => a * 2;
            int result = b(3);
        }
    }
}
