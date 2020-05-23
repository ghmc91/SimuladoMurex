namespace SimuladoMurex.Domain.Entities
{
    public class Fx
    {
        public string Broker { get; set; }
        public bool Dma { get; set; }
        public bool Status { get; set; }

        public virtual Mo Mo { get; set; }
    }
}