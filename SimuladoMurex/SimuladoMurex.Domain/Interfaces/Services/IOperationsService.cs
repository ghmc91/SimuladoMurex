using SimuladoMurex.Domain.Entities.Reports;
using System;
using System.Collections.Generic;

namespace SimuladoMurex.Domain.Interfaces.Services
{
    public interface IOperationsService
    {
        IEnumerable<ReportCustomers> GetOperations();
    }
}
