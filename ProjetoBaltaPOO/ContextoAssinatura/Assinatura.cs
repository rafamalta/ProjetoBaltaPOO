using ProjetoBaltaPOO.ContextoCompartilhado;

namespace ProjetoBaltaPOO.ContextoAssinatura
{
    public class Assinatura : EntidadeBase
    {
        public Plano Plano { get; set; }
        public DateTime? DataFinal { get; set; }
        public bool Inativo => DataFinal <= DateTime.Now;
    }
}
