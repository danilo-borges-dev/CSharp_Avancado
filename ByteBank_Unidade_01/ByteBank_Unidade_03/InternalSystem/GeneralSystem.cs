using System;

namespace ByteBank_Unidade_03.InternalSystem
{
    internal static class GeneralSystem
    {
        public static bool Login(bool approved)
        {
            if (approved)
            {
                Console.WriteLine("Bem-vindo ao Sistema!");
                return true;
            }
            return false;
        }
    }
}
