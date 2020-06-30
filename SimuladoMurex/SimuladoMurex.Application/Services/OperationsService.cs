using SimuladoMurex.Domain.Entities;
using SimuladoMurex.Domain.Entities.Customers;
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
        private readonly ICustomersRepository _customerRepository;

        public OperationsService(IMoRepository moRepository, ICustomersRepository customersRepository)
        {
            _moRepository = moRepository;
            _customerRepository = customersRepository;
        }

        public IEnumerable<ReportCustomerKey> GetOperations()
        {
            var reports = new ReportCustomerKey();
            var customers = new Customers();

            var reportsCounterparties = reports.LoadData(_moRepository.Get(x => !string.IsNullOrEmpty(x.Counterparty), i => i.Ir));
            var customersData = customers.LoadData(_customerRepository.Get(x => !string.IsNullOrEmpty(x.Customer)));

            reportsCounterparties.ToList().ForEach(x =>
            {
                customersData.ToList().ForEach(i =>
                {
                    if (x.Counterparty == i.Customer)
                    {
                        x.Email = i.Email;
                    }
                });
            });

            return reportsCounterparties;
        }

        public IEnumerable<Customers> Get()
        {
            var customers = new Customers();

            var customersData = customers.LoadData(_customerRepository.Get(x => !string.IsNullOrEmpty(x.Customer)));

            return customersData;
        }
    }
}
