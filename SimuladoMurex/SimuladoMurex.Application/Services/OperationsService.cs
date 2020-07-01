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
            
            var reportsCounterparties = reports.LoadData(_moRepository.Get(x => !string.IsNullOrEmpty(x.Counterparty), i => i.Ir));
            var customers = GetCustomers();

            var reportJoinCustomer = reportsCounterparties.Join(customers,
                rc => rc.Counterparty,
                c => c.Customer,
                (rc, c) => new ReportCustomerKey
                {
                    Counterparty = rc.Counterparty,
                    Email = c.Email,
                    rc = rc.rc
                });

            return reportJoinCustomer;
        }

        public IEnumerable<Customers> GetCustomers()
        {
            var customers = new Customers();

            var customersData = customers.LoadData(_customerRepository.Get(x => !string.IsNullOrEmpty(x.Customer)));

            return customersData;
        }
    }
}
