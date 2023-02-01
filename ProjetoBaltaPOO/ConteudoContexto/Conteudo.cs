using ProjetoBaltaPOO.ContextoCompartilhado;

namespace ProjetoBaltaPOO.ConteudoContexto
{
    public abstract class Conteudo : EntidadeBase
    {
        public string Titulo { get; set; }
        public string Url { get; set; }

        public Conteudo(string titulo, string url)
        {            
            Titulo = titulo;
            Url = url;
        }
    }
}
