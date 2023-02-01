using ProjetoBaltaPOO.ContextoCompartilhado;

namespace ProjetoBaltaPOO.ContextoAssinatura
{
    public class Usuario : EntidadeBase
    {
        public string NomeDoUsuario { get; set; }
        public string Senha { get; set; }
    }
}
