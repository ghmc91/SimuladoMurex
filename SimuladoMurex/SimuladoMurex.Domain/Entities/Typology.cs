namespace SimuladoMurex.Domain.Entities
{
    public class Typology
    {
        public enum TypologyId : byte
        {
            FxFuture = 1,
            EqFuture = 2,
            CmFuture = 3,
            IrFuture = 4
        }

        public enum TypologyName
        {
            FxFuture,
            EqFuture,
            CmFuture,
            IrFuture,
        }

        public enum GroupTypology 
        { 
            Equitites,
            Commodities,
            InterestRate,
            ForeignExchange
        }
    }
}
