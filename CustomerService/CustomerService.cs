using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Models;

namespace CustomerService
{
    public class CustomerService
    {
        private readonly int _CustomerID;

        public CustomerService(int CustomerID)
        {
            _CustomerID = CustomerID;
        }

        public Customer GetCustomer()
        {
            using (var ctx = new Atm_AppEntities())
            {
                var e = ctx.Customers.Find(_CustomerID);
                if(e != null)
                {
                    return new Customer
                    {
                        CustomerID = e.CustomerID,
                        FirstName = e.FirstName,
                        LastName = e.LastName
                    };
                }

                return null;
            }
        }
        public string GetFirstName()
            {
                return GetCustomer().FirstName;
            }
        public string GetLastName()
            {
                return GetCustomer().LastName;
            }
        public string GetFullName()
            {
                return GetFirstName() + "" + GetLastName();
            }
 
    }
}
