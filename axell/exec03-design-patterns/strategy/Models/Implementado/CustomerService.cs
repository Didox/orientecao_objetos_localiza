using System;
using System.Collections.Generic;

namespace strategy.Models.Implementado
{
    public class CustomerService
    {
        public static void Save(ICustomer customer)
        {
            customer.Save();
        }

        public static List<ICustomer> All()
        {
            return new List<ICustomer>();
        }
    }
}
