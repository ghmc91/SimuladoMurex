using System.Collections.Generic;

namespace SimuladoMurex.Domain.Interfaces.Repositories
{
    public interface IMoRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
    }
}
