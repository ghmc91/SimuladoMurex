namespace SimuladoMurex.Domain.Entities
{
    public class Cm
    {
        public string Currency { get; set; }
        public string Notional { get; set; }
        public decimal Settlement { get; set; }

        public virtual Mo Mo { get; set; }
    }
}