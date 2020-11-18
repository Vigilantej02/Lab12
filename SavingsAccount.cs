using System;

class SavingsAccount : BankAccount
    {
      public override void CalculateInterest()
      {
        double interest = Balance * (.005 * DateCreated.Year - DateTime.Today.Year);
        Balance += interest;
      }
      new public void Withdraw(double amount)
      {
        if (Balance < 2000)
        {
          Console.WriteLine("Error: Insufficient Funds");
        }
        else 
        {
          base.Withdraw(amount);
        }
      }
    }