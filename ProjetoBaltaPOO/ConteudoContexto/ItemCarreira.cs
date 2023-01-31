using ProjetoBaltaPOO.NotificacaoContexto;

namespace ProjetoBaltaPOO.ConteudoContexto
{
    public class ItemCarreira : EntidadeBase
    {
        public int Pedido { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public Curso Curso { get; set; }

        public ItemCarreira(int pedido, string titulo, string descricao, Curso curso)
        {
            if (curso == null)
            {
                AdicionarNotificacao(new Notificacao("Curso", "Curso inválido!"));
            }
            Pedido = pedido;
            Titulo = titulo;
            Descricao = descricao;
            Curso = curso;
        }
    }
}
