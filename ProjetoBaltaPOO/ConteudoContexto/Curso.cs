using ProjetoBaltaPOO.ConteudoContexto.Enums;

namespace ProjetoBaltaPOO.ConteudoContexto
{
    public class Curso : Conteudo
    {
        public string Tag { get; set; }
        public IList<Modulo> Modulos { get; set; }
        public int DuracaoEmMinutos { get; set; }
        public EConteudoNivel Nivel { get; set; }

        public Curso(string titulo, string url) : base(titulo, url)
        {
            // inicializa a lista
            Modulos = new List<Modulo>();
        }
    }
}
