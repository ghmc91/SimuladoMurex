using SimuladoMurex.Domain.Entities;
using SimuladoMurex.Domain.Interfaces.Repositories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SimuladoMurex.Infra.Data.Context;

namespace SimuladoMurex.Infra.Data.Repositories
{

    public class MoRepository : IMoRepository
    {
        public IQueryable<Mo> Entity { get; set; }

        public MoRepository(SimuladoMurexContext db)
        {
            Entity = db.Mos.AsQueryable();
        }

        public IEnumerable<Mo> Get(Expression<Func<Mo, bool>> predicate)
        {
            Entity = Entity.Where(predicate);

            return Entity;
        }

        public IEnumerable<Mo> Get(Expression<Func<Mo, bool>> predicate, Expression<Func<Mo, object>> include)
        {
            if (include != null)
            {
                Entity = Entity.Where(predicate).Include(include);
            }

            Entity = Entity.Where(predicate);
            return Entity;
        }
    }
}
