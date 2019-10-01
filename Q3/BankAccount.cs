using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class BankAccount
    {



        public BankAccount(string n, int a, double b)
        {
            CustomerName = n;
            AccountNum = a;
            Balance = b;


        }
        public string CustomerName { get; set; }

        public int AccountNum { get; set; }

        public double Balance { get; set; }

  

        public double Withdraw(int withdraw)
        {
            Balance = Balance - withdraw;
            return Balance;
        }
        public double Lodge(int lodge)
        {
            Balance = Balance + lodge;
            return Balance;
        }
        public override string ToString()
        {
            return "Your Name is: "+CustomerName+"Your Account Number is: "+AccountNum+"The balance after any changes is " + Balance;
        }

    }
}
