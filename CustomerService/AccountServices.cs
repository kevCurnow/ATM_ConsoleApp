using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Models;

namespace Bank.Services
{
    public class AccountServices
    {
        public Account GetAccountById(int num)
        {
            return
                new Atm_AppEntities()
                .Accounts
                .SingleOrDefault(e => e.AccountID == num);
        }

        public Account GetAcct(int AccountID)
        {
            using (var ctx = new Atm_AppEntities())
            {
                var e = ctx.Accounts.Find(AccountID);
                if (e != null)
                {
                    return new Account
                    {
                        CustomerID = e.CustomerID,
                        AccountID = e.AccountID,
                        AccountType = e.AccountType,
                        AccountNumber = e.AccountNumber,
                        PIN = e.PIN 
                    };
                }

                return null;
            }
        }

    }
}
