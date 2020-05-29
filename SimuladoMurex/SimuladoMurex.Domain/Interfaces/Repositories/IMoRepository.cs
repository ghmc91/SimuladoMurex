using SimuladoMurex.Domain.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SimuladoMurex.Domain.Interfaces.Repositories
{
    public interface IMoRepository
    {
        public IEnumerable<Expression<Func<Mo, bool>>> Get(IEnumerable<Expression<Func<Mo, object>>> Include);
    }
}
