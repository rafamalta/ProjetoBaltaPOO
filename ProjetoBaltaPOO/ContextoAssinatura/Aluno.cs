using ProjetoBaltaPOO.ContextoCompartilhado;
using ProjetoBaltaPOO.NotificacaoContexto;

namespace ProjetoBaltaPOO.ContextoAssinatura
{
    public class Aluno : EntidadeBase
    {
        public string NomeDoAluno { get; set; }
        public string Email { get; set; }
        public Usuario Usuario { get; set; }
        public IList<Assinatura> Assinatura { get; set; }
        public bool AlunoPremium => Assinatura.Any(x => !x.Inativo);

        public Aluno()
        {
            Assinatura = new List<Assinatura>();
        }

        public void CriarAssinatura(Assinatura assinatura)
        {
            if (AlunoPremium)
            {
                AdicionarNotificacao(new Notificacao("Premium",
                    "O aluno já possui uma assinatura ativa!"));
                return;
            }

            Assinatura.Add(assinatura);
        }
    }
}
