using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontoBankowe
{
    internal class BankAccount
    {
        private string _accountNumber;
        private decimal _saldo;

        public BankAccount(string accountNumber, decimal saldo)
        {
            _accountNumber = accountNumber;
            _saldo = saldo;
        }

        public string GetAccountNumber()
        {
            return _accountNumber;
        }

        public decimal GetSaldo()
        {
            return _saldo;
        }

        public void Wplata(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Kwota wpłaty musi być większa od zera.");

            }

            _saldo += amount;
        }

        public void Wyplata(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Kwota wyyplaty musi byc wieksza od zera");
            }

            if (amount > _saldo)
            {
                throw new InvalidOperationException("Niewystarczajace srodki na koncie.");

            }
            _saldo -= amount;
        }
    }
}
