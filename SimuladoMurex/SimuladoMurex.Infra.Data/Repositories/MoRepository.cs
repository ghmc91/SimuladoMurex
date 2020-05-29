using SimuladoMurex.Domain.Entities;
using SimuladoMurex.Domain.Interfaces.Repositories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace SimuladoMurex.Infra.Data.Repositories
{
    public class MoRepository : IMoRepository
    {
        public IQueryable Entity;

        public Expression<Func<Mo, bool>> Get(Expression<Func<Mo, object>> Include)
        {
            if (Include != null)
            {
                Entity = Entity.Include(Include);
            }


            return Entity;
        }
    }
}
