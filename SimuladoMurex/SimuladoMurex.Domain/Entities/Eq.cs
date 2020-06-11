namespace SimuladoMurex.Domain.Entities
{
    public class Eq
    {
        public int MoId { get; set; }
        public bool Buy { get; set; }
        public int ContractId { get; set; }
        public decimal Rate { get; set; }

        public virtual Mo Mo { get; set; }
    }
}