using System;
using System.Collections.Generic;
using Bank.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Services
{
    public class DepositService
    {
        public bool Deposit(decimal amount, int num)
        {
            using (var ctx = new Atm_AppEntities())
            {
                var Transaction =
                    new Transaction
                    {
                        TransactionType = 0,
                        AccountID = num
                    };
                var deposit =
                    new Deposit
                    {
                        Amount = amount,
                    }; 
                
            ctx.Deposits.Add(deposit);

            ctx.Accounts.SingleOrDefault(e => e.AccountID == num).Balance += amount;
            return ctx.SaveChanges() == 3;
            }
        }
    }
}
