using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Unidade_01
{
    internal class Client
    {
        private string _clienteName;
        private int _clienteId;
        private int _clientAge;
        private char _sex;

        public Client() { }

        public Client(string clienteName, int clienteId, int clientAge, char sex)
        {
            _clienteName = clienteName; // Titular
            _clienteId = clienteId;
            _clientAge = clientAge;
            _sex = sex;
        }

        public void SetClientName(string name) => _clienteName = name;
        public void SetClienteId(int clienteId) => _clienteId = clienteId;
        public void SetClientAge(int age) => _clientAge = age;
        public void SetClientSex(char sex) => _sex = sex;

        public string GetClientName() => _clienteName;
        public int GetClienteId() => _clienteId;
        public int GetClientAge() => _clientAge;    
        public char GetSex() => _sex;

    }
}
