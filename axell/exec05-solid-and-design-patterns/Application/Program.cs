using System;
using System.Collections.Generic;
using Business.Models;
using Business.Services;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer()
            {
                Id = 1,
                Name = "Customer1",
            };
            var orders = new List<Order>();

            for (int i = 1; i <= 3; i++)
            {
                orders.Add(new Order
                {
                    Id = i,
                    Customer = customer
                });
            }

            orders.ForEach(OrderCrudService.Save);
        }
    }
}
