using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerService
{
    public class AuthService
    {
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
    }
}
