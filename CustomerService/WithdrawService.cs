using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Models;

namespace Bank.Services
{
    public class WithdrawService
    {

        

        public bool Withdraw(decimal amount, int num)
        {
            using (var ctx = new Atm_AppEntities())
            {
                var Transaction =
                    new Transaction
                    {
                        TransactionType = 1,
                        AccountID = num
                    };
                

                if (amount <= GetAccountById(num).Balance)
                {
                    var withdraw =
                    new Withdrawl
                    {

                        Amount = amount,
                    };

                    ctx.Withdrawls.Add(withdraw);

                    ctx.Accounts.SingleOrDefault(e => e.AccountID == num).Balance -= amount;
                    

                    return ctx.SaveChanges() == 3;
                }
                Console.WriteLine("You are trying to withdraw more funds than you have. Please try again.");
                return ctx.SaveChanges() == 0;
            }
        }
    }
}
