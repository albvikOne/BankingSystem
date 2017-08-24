using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.BakingClasses
{
    class Customer
    {
        public int customerID;
        public string customerName;
        public string customerSurname;
        public string customerAddress;
        public int customerPhoneNumber;
        public int accountNr;

        //ask for bank information
        public void GeneralInquiry() { }
        public void DepositMoney() { }
        public void WithdrawMoney() { }
        public void OpenAccount() { }
        public void CloseAccount() { }
        public void ApplyForLoan() { }
        public void RequestCard() { }

    }
}
