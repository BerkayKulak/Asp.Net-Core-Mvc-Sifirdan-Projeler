using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelBinding.Models
{
    public interface IRepository
    {
        List<Customer> Customers { get; }
        Customer Get(int customerId);
    }

    public class Repository : IRepository
    {
        public List<Customer> _customers;

        public Repository()
        {
            _customers = new List<Customer>()
            {
                new Customer() {CustomerId = 1, FirstName = "Ali", LastName = "Yılmaz",},
                new Customer() {CustomerId = 2, FirstName = "Canan", LastName = "Demir",},
                new Customer() {CustomerId = 3, FirstName = "Şenol", LastName = "Özcan",},
                new Customer() {CustomerId = 4, FirstName = "Çınar", LastName = "Turan",},
                new Customer() {CustomerId = 5, FirstName = "Emel", LastName = "Turan",}
            };
        }

        public List<Customer> Customers => _customers;

        public Customer Get(int customerId) => _customers.FirstOrDefault(i => i.CustomerId == customerId);
    }

}
