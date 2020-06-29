using SimuladoMurex.Domain.Entities.Customers;
using SimuladoMurex.Domain.Interfaces.Repositories;
using SimuladoMurex.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SimuladoMurex.Infra.Data.Repositories
{
    public class CustomersRepository : ICustomersRepository
    {
        public IQueryable<Customers> Entity { get; set; }

        public CustomersRepository(CustomersContext db)
        {
            Entity = db.Customers.AsQueryable();
        }

        public IEnumerable<Customers> Get(Expression<Func<Customers, bool>> predicate)
        {
            Entity = Entity.Where(predicate);

            return Entity;
        }
    }
}
