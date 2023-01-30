using ProjetoBaltaPOO.NotificacaoContexto;

namespace ProjetoBaltaPOO.ConteudoContexto
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
