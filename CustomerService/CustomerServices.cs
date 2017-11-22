using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Models;

namespace Bank.Services
{
    public class CustomerServices
    {
        public Customer GetCustomer(int CustomerID)
        {
            using (var ctx = new Atm_AppEntities())
            {
                var e = ctx.Customers.Find(CustomerID);
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
 
    }
}
