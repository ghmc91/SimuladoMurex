using SimuladoMurex.Domain.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SimuladoMurex.Domain.Interfaces.Repositories
{
    public interface IMoRepository
    {
        public IEnumerable<Mo> Get(Expression<Func<Mo, bool>> predicate); 
        public IEnumerable<Mo> Get(Expression<Func<Mo, bool>> predicate, Expression<Func<Mo, object>> include);
    }
}
