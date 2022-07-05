using System;

namespace ByteBank_Unidade_03.Employees
{
    internal class Person
    {
        public string CPF { get; }
        public int ID { get; }

        public Person(string cpf, int id)
        {
            if (id <= 0)
            {
                string msg = "Ocorreu uma exceção do tipo ArgumentException.";
                ArgumentException argumentException = new ArgumentException(msg);
                throw new ArgumentException(msg, nameof(id));
            }

            CPF = cpf;
            ID = id;
        }
    }
}
