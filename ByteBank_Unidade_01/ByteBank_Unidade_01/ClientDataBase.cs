using System;
using System.Collections.Generic;

namespace ByteBank_Unidade_01
{
    internal static class ClientDataBase
    {
        private static List<Object> _clientList = new List<object>();
        private static List<Object> _clientCurrenteAccount = new List<object>();

        public static void AddNewClientEnDataBase(object clienteReference, object currrentAccountReference)
        {
            _clientList.Add(clienteReference);
            _clientCurrenteAccount.Add(currrentAccountReference);
        }

        public static List<Object> ClientList ()
        {
            return _clientList;
        }
    }
}
