using System;
using System.Collections.Generic;
using System.Text;

namespace LV6
{
    class BankAccountMemento
    {
        private string ownerName;
        private string ownerAddress;

        private decimal balance;

        public BankAccountMemento(string ownerName, string ownerAddress, decimal balance)
        {
            this.ownerName = ownerName;
            this.ownerAddress = ownerAddress;
            this.balance = balance;
        }

        public void ChangeOwnerAddress(string address)
        {
            this.ownerAddress = address;
        }

        public void UpdateBalance(decimal amount) { this.balance += amount; }
        public string OwnerName { get { return this.ownerName; } }
        public string OwnerAddress { get { return this.ownerAddress; } }
        public decimal Balance { get { return this.balance; } }

        public BankAccountMemento(BankAccount account)
        {
            this.ownerName = account.OwnerName; this.ownerAddress = account.OwnerAddress; this.balance = account.Balance;
        }
        public void AddPreviousState(BankAccount account)
        {
            balance = account.Balance;
        }
    }
}
