using Bank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerService
{ 
    public class AuthService
    {
        private Atm_AppEntities db = new Atm_AppEntities();

        public int GetAccount()
        {
            Console.WriteLine("Please enter your account number");
            int AcctNum = Int32.Parse(Console.ReadLine());
            return AcctNum;
        }

        public int GetPin()
        {
            Console.WriteLine("Please enter you pin number");
            int AcctPin = Int32.Parse(Console.ReadLine());
            return AcctPin;
        }

        public bool Verify(int AcctNum, int AcctPin)
        {
            var Verified = from a in db.Accounts
                           where a.AccountNumber == AcctNum && a.PIN == AcctPin
                           select a;

            foreach (var acc in Verified)
            {
                if (acc == null)
                {
                    Console.WriteLine("We can't seem to find you in our database.");
                    return false;
                }
                else
                {
                    Console.WriteLine("Yay verified!");
                    return true;
                }
            }
            Console.WriteLine("User does not exist.");
            return false;
        }
    }
}
