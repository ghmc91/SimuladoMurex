using SimuladoMurex.Domain.Entities.Customers;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SimuladoMurex.Domain.Interfaces.Repositories
{
    public interface ICustomersRepository
    {
        public IEnumerable<Customers> Get(Expression<Func<Customers, bool>> predicate);
    }
}
