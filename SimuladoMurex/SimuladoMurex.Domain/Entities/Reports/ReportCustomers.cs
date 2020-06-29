using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimuladoMurex.Domain.Entities.Reports
{
    public class ReportCustomers
    {
        public DateTime TradeDate { get; set; }
        public string Isin { get; set; }
        public int Typology { get; set; 
        }
        
    }

    public class ReportCustomerKey
    {
        public string Counterparty { get; set; }
        public IEnumerable<ReportCustomers> rc { get; set; }

        public IEnumerable<ReportCustomerKey> LoadData(IEnumerable<Mo> data)
        {
            return data.GroupBy(x => x.Counterparty)
                       .Select(x => new ReportCustomerKey
                       {
                           Counterparty = x.Key,
                           rc = x.Select(i => new ReportCustomers
                           {
                               TradeDate = i.TradeDate,
                               Isin = i.Ir.Isin
                           }).ToList()
                       });
        }
    }
}
