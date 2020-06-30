using System.Collections.Generic;
using System.Linq;

namespace SimuladoMurex.Domain.Entities.Customers
{
    public class Customers
    {
        public string Customer { get; set; }
        public string Email { get; set; }

        public IEnumerable<Customers> LoadData(IEnumerable<Customers> data)
        {
            return data.Select(x => new Customers
            {
                Customer = x.Customer,
                Email = x.Email
            }).ToArray();
        }
    }
}
