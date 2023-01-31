namespace ProjetoBaltaPOO.NotificacaoContexto
{
    public abstract class Notificador
    {
        public List<Notificacao> Notificacoes { get; set; }
        public bool Invalido => Notificacoes.Any();

        public Notificador()
        {
            Notificacoes = new List<Notificacao>();
        }

        public void AdicionarNotificacao(Notificacao notificacao)
        {
            Notificacoes.Add(notificacao);
        }

        public void AdicionarNotificacoes(IEnumerable<Notificacao> notificacoes)
        {
            Notificacoes.AddRange(notificacoes);
        }
    }
}
