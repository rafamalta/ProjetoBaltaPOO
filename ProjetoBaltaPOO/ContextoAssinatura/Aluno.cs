using ProjetoBaltaPOO.ContextoCompartilhado;

namespace ProjetoBaltaPOO.ContextoAssinatura
{
    public class Aluno : EntidadeBase
    {
        public string NomeDoAluno { get; set; }
        public string Email { get; set; }
        public Usuario Usuario { get; set; }
    }
}
