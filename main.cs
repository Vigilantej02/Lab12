using System;

class MainClass {
  public static void Main (string[] args) {
          // Create a savingsaccount object
            SavingsAccount s1 = new SavingsAccount();
            //Deposit $2000
            s1.Deposit(2000);
            //Withdraw $5000
            s1.Withdraw(5000);
            //Calculate interest
            s1.CalculateInterest();
            // Withdraw $500
            s1.Withdraw(500);

          //Create a checkingaccount object
           CheckingAccount c1 = new CheckingAccount();
            //Deposit $2000
            c1.Deposit(2000);
            //Withdraw $5000
            c1.Withdraw(5000);
            //Calculate interest
            c1.CalculateInterest();
            //Withdraw $500
            c1.Withdraw(500);
  }
}
