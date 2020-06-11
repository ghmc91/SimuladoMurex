using SimuladoMurex.Domain.Entities;
using SimuladoMurex.Domain.Entities.Reports;
using SimuladoMurex.Domain.Interfaces.Repositories;
using SimuladoMurex.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimuladoMurex.Application.Services
{
    public class OperationsService : IOperationsService
    {
        private readonly IMoRepository _moRepository;

        public OperationsService(IMoRepository moRepository)
        {
            _moRepository = moRepository;
        }

        public IEnumerable<ReportCustomers> GetOperations()
        {
            var reports = new ReportCustomers();

            var reportsCounterparties = reports.LoadData(_moRepository.Get(x => !string.IsNullOrEmpty(x.Counterparty), i => i.Ir));

            reportsCounterparties.Select(x => x.Counterparty);

            return reportsCounterparties;
        }
    }
}
