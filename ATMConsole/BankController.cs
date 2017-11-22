
using CustomerService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMConsole
{
    public class BankController
    {
        
        public static void RunAtm()
        {
            CustomerServices custService = new CustomerServices();
            Console.Title = "ASCII Art";

            string art = @"
         _._._                       _._._
        _|   |_                     _|   |_
        | ... |_._._._._._._._._._._| ... |
        | ||| |  o NATIONAL BANK o  | ||| |
        | $$$ |  $$$    $$$    $$$  | $$$ |
   ())  |[-|-]| [-|-]  [-|-]  [-|-] |[-|-]|  ())
  (())) |     |---------------------|     | (()))
 (())())| $$$ |  $$$    $$$    $$$  | $$$ |(())())
 (()))()|[-|-]|  :::   .-*-.   :::  |[-|-]|(()))()
 ()))(()|     | |~|~|  |_|_|  |~|~| |     |()))(()
    ||  |_____|_|_|_|__|_|_|__|_|_|_|_____|  ||
 ~ ~^^ @@@@@@@@@@@@@@/=======\@@@@@@@@@@@@@@ ^^~ ~
      ^~^~                                ~^~^ 
            ";
            Console.WriteLine(art);
            AuthService authService = new AuthService();
            int actNum = authService.GetAccount();
            int actPin = authService.GetPin();
            bool isAuthed = authService.Verify(actNum, actPin);
            Console.WriteLine($"{isAuthed}");

            Console.Clear();
            var user = custService.GetCustomer();
            Console.WriteLine($"Welcome {user.FirstName}, what would you like to do?\n" +
                "0: View Account Details\n" +
                "1: Make a Deposit\n" +
                "2: Make a Withdrawal\n" +
                "3: Exit ATM"
                
                
                );

            
        }
    }
}
