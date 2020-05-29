using System;
using System.Collections.Generic;
using System.Text;

namespace SimuladoMurex.Domain.Entities.Customers
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
