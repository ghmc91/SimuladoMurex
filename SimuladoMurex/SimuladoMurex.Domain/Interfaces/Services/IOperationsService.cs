using SimuladoMurex.Domain.Entities.Customers;
using SimuladoMurex.Domain.Entities.Reports;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SimuladoMurex.Domain.Interfaces.Services
{
    public interface IOperationsService
    {
        IEnumerable<ReportCustomerKey> GetOperations();
        IEnumerable<Customers> GetCustomers();
    }
}
