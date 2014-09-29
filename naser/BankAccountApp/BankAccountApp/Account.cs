using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccountApp
{
    class Account
    {
        private string acNumber;
        private string acName;
        private double acBalance;

        public void SetacNumber(string acNumber)
        {
            this.acNumber = acNumber;
        }

        public string GetacNumber()
        {
            return acNumber;
        }

        public void SetacName(string acName)
        {
            this.acName = acName;
        }

        public string GetacName()
        {
            return acName;
        }

        public double GetacBalance()
        {
            return acBalance;
        }

        //public string Number
        //{
        //    set 
        //    {
        //       acNumber = value;
        //    }

        //    get
        //    {
        //        return acNumber;
        //    }
        //}

        //public string Name
        //{
        //    set
        //    {
        //        acName = value;
        //    }

        //    get
        //    {
        //        return acName;
        //    }
        //}

        //public double Balance
        //{
        //    get
        //    {
        //        return acBalance;
        //    }

        //}

        public void Deposit(double amount)
        {
            acBalance += amount;
        }

        public void Withdrawn(double amount)
        {
             acBalance -= amount;
        }
    }
}
