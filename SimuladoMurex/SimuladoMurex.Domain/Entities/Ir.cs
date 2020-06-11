namespace SimuladoMurex.Domain.Entities
{
    public class Ir
    {
        public int MoId { get; set; }
        public string Isin { get; set; }
        public decimal Price { get; set; }
        public int Trader { get; set; }

        public virtual Mo Mo { get; set; }
    }
}