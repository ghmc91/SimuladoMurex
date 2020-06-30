using System;
using System.Collections.Generic;
using System.Text;

namespace SimuladoMurex.Domain.Entities
{
    public class Mo
    {
        public int MoId { get; set; }
        public DateTime TradeDate { get; set; }
        public string Counterparty { get; set; }

        public Ir Ir { get; set; }

        public Fx Fx { get; set; }

        public Eq Eq { get; set; }

        public Cm Cm { get; set; }

        public Typology Typology { get; set; }

    }
}
