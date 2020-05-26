using System.Collections;
using System.Collections.Generic;

namespace SimuladoMurex.Domain.Interfaces.Repositories
{
    public interface IMoRepository
    {
        IEnumerable GetAll();
    }
}
