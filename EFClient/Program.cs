using EFPrincipal.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new EFDatabaseEntities())
            {
                var customer = context.Customers.ToList();
                var jsonCustomer = JsonConvert.SerializeObject(customer, Formatting.Indented,
                new JsonSerializerSettings
                {
                    //PreserveReferencesHandling = PreserveReferencesHandling.Objects
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                });

                Console.Write(jsonCustomer);
                Console.ReadLine();
            }
        }
    }
}
