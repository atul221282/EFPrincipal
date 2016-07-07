using EFPrincipal.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFClient.Helper;
using System.Data.Entity;
namespace EFClient
{
    class Program
    {
        static void Main(string[] args)
        {
            GetCustomer();
        }

        private static void GetCustomer()
        {
            using (var context = new EFDatabaseEntities())
            {
                var customer = context.Customers.Include(m => m.CustomerOrders).ToList();
                var jsonCustomer = customer.SerializeObject<Customer>();
                Console.Write(jsonCustomer);
                Console.ReadLine();
            }
        }
    }
}
