using System;

namespace ByteBank_Unidade_03.Employees
{
    internal class DontExistEployeeException : Exception
    {
        public int ID { get; }
        public DontExistEployeeException() { }
        public DontExistEployeeException(int id) : this($"Tentativa de locação de Funcionário com ID {id}, porém não foi possível localizar.") 
        {
            ID = id;
        }
        public DontExistEployeeException(string message) : base(message) { }
    }
}
