namespace ProjetoBaltaPOO.NotificacaoContexto
{
    public abstract class Notificador
    {
        public List<Notificacao> Notificacoes { get; set; }

        public void Add(Notificacao notificacoes)
        {
            Notificacoes.Add(notificacoes);
        }

        public void AddRange(IEnumerable<Notificacao> notificacoes)
        {
            Notificacoes.AddRange(notificacoes);
        }
    }
}
