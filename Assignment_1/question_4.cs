using System;
namespace Assignment_1
{
    internal class BankAcc
    {
        string name = "null";
        string Acc_type = "null";
        int saving_rate = 6;
        int current_rate = 5;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string AccountType
        {
               get { return Acc_type; }
                set { Acc_type = value; }
        }
        public int SavingRate
        {
            get { return saving_rate; }
            set
            {
                saving_rate = value;
            }
        }

        public int CurrentRate
        {
            get { return current_rate; }
            set
            {
                current_rate = value;
            }
        }

    }

    class Bank : BankAcc
    {
        public void OpenBankAccount(string uName, string aType)
        {
            Name = uName;
            AccountType = aType;
        }
    }

    class Customer: Bank
    {
        public Customer()
        {
            
        }
        public Customer(string uName,string aType)
        {
            Name=uName; 
            AccountType=aType;
        }
        public double CalculateSavingRate(int p,int t)
        {
            double rate = (p * t * SavingRate) / 100;
            Console.WriteLine("User Name : "+Name);
            Console.WriteLine("Account Type is : "+AccountType);
            Console.WriteLine("Interest is : "+rate);
            return rate;
        }
    }
}
