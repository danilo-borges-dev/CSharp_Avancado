using System;

namespace ByteBank_Unidade_02
{
    internal class CurrentAccount
    {
        private Client _holder { get; set; } // Titular
        private int _agency { get; set; }
        private int _numberAccount { get; set; }
        private double _balance { get; set; }
        public static int _totalCurrentAccountBank { get; private set; } = 0;  // Aqui nos termos uma property mais simples e moderna

        public CurrentAccount() { }

        public CurrentAccount(Client holder, int agency, int number, double balance)
        {
            _holder = holder; // Titular
            _agency = agency;
            _numberAccount = number;
            _balance = balance;
            _totalCurrentAccountBank++;
        }

        public void SetHolderName(Client name) => _holder = name; // Lambda Expression
        public void SetAgencyNumber(int number) => _agency = number;
        public void SetNumberAccount(int number) => _numberAccount = number;
        public void SetBalance(double balanceValue) => _balance = balanceValue;

        public Client GetHolderName() => _holder;
        public int GetAgencyNumber() => _agency;
        public int GetNumberAccount() => _numberAccount;
        public double GetBalance() => _balance;


        public int GetTotalCurrenteAccountBank() => _totalCurrentAccountBank;

        public override string ToString()
        {
            for (int i = 0; i <= _totalCurrentAccountBank; i++)
            {

            }

            string infos = "\n\nName: " + _holder.GetClientName() + "\n" +
                "Agency: " + _agency + "\n" +
                "Number Account: " + _numberAccount + "\n" +
                "Balance: " + _balance + "\n";
            return infos.ToString();
        }
    }
}
