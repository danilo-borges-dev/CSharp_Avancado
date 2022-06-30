namespace ByteBank_Unidade_01
{
    internal class CurrentAccount
    {
        private Client _holder { get; set; } // Titular
        private int _agency { get; set; }
        private int _numberAccount { get; set; }
        private double _balance { get; set; }
        private static int _totalCurrentAccountBank = 0;

        public CurrentAccount() { }

        public CurrentAccount(Client holder, int agency, int number, double balance)
        {
            _holder = holder; // Titular
            _agency = agency;
            _numberAccount = number;
            _balance = balance;
            _totalCurrentAccountBank++;
        }

        public void SetHolderName(Client name) => _holder = name;

        public void SetAgencyNumber(int number) => _agency = number;

        public void SetNumberAccount(int number) => _numberAccount = number;

        public void SetBalance(double balanceValue) => _balance = balanceValue;

        public Client GetHolderName() => _holder;

        public int GetAgencyNumber() => _agency;
        public int GetNumberAccount() => _numberAccount;

        public double GetBalance() => _balance;

        public int GetTotalCurrenteAccountBank() => _totalCurrentAccountBank;

    }
}
