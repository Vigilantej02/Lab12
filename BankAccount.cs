 using System;
 
 abstract class BankAccount
    {
        public string AcctNbr { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
        public DateTime DateCreated { get; set; }

        public BankAccount()
        {
            Balance = 1000;
        }

         public BankAccount(double balance)
        {
            Balance = balance;
        }

        public void Deposit(double amount)
        {
           Balance += amount;
           Console.WriteLine("Current Balance Is: " + Balance);
        }

        public virtual double Withdraw(double amount)
        {
          if (Balance > amount)
          {
            Balance -= amount;
          }
          else 
          {
            Console.WriteLine("Error.");
          }
          return Balance;
        }
        public abstract void CalculateInterest();

    }