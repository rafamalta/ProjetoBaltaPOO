using ProjetoBaltaPOO.NotificacaoContexto;

namespace ProjetoBaltaPOO.ContextoCompartilhado
{
    public abstract class EntidadeBase : Notificador
    {
        public Guid Id { get; set; }

        public EntidadeBase()
        {
            Id = Guid.NewGuid();
        }
    }
}
