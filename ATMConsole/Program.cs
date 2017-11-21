using CustomerService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            AuthService authService = new AuthService();
            int actNum = authService.GetAccount();
            int actPin = authService.GetPin();
            bool isAuthed = authService.Verify(actNum, actPin);
            Console.WriteLine($"{isAuthed}");
        }
    }
}
