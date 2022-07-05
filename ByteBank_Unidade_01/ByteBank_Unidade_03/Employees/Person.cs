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
                DontExistEployeeException argumentException = new DontExistEployeeException();
                throw new DontExistEployeeException(id);
            }
            CPF = cpf;
            ID = id;
        }
    }
}
