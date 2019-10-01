using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Program
    {
        /*Create a class called Bank Account with the following properties – Account Number, Account Holder, 
         * Balance.Use shorthand properties.Create a constructor which takes all properties as parameters.
         * Create two bank account objects and display the bank details in your program.Add methods to deposit 
         * and withdraw money from the bank accounts.  Add a method to display account details and make use of 
         * all of these methods using the Console to display the changes.*/
        static void Main(string[] args)
        {
            BankAccount myBankAccount = new BankAccount("Tara", 12, 1200);
            BankAccount myBankAccount2 = new BankAccount("Sean", 13, 1000);

            Console.WriteLine(myBankAccount.ToString());
            Console.WriteLine(myBankAccount2.ToString());

            myBankAccount.Lodge(100);
            myBankAccount2.Lodge(200);
            myBankAccount.Withdraw(300);
            myBankAccount2.Withdraw(500);

            Console.WriteLine(myBankAccount.ToString());
            Console.WriteLine(myBankAccount2.ToString());






        }
    }
}
