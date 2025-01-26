using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Customer
    {
        public Customer(string id, string firstName, string lastName, decimal saldo)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Saldo = saldo;
        }

        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{LastName} {FirstName}";
        public decimal Saldo { get; set; }
    }
}
