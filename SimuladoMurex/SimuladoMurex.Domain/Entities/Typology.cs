using System.Collections.Generic;

namespace SimuladoMurex.Domain.Entities
{
    public class Typology
    {
        public int TypologyId { get; set; }
        public string TypologyName { get; set; }
        public int GroupTypology { get; set; }

        public List<Mo> Mos { get; set; }

    }
}
