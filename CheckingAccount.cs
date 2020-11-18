using System;

class CheckingAccount : BankAccount
    {
      public override void CalculateInterest()
      {
        double interest = Balance * (.05 * DateCreated.Year - DateTime.Today.Year);
        Balance += interest;
      }
      new public void Withdraw(double amount)
      {
        base.Withdraw(amount);
      }
    }