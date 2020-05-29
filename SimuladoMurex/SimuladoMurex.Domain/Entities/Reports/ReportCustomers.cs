using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimuladoMurex.Domain.Entities.Reports
{
    class ReportCustomers
    {
        public string Counterparty { get; set; }
        public DateTime TradeDate { get; set; }
        public string Isin { get; set; }
        public int Typology { get; set; }

        public IEnumerable<ReportCustomers> LoadMurexData(IEnumerable<Mo> data)
        {
            return data.Select(x => new ReportCustomers
            {
                Counterparty = x.Counterparty,
                TradeDate = x.TradeDate,
                Isin = x.Ir.Isin,
                Typology = x.Typology.TypologyId
            });
        }
    }
}
