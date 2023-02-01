using ProjetoBaltaPOO.ConteudoContexto.Enums;
using ProjetoBaltaPOO.ContextoCompartilhado;

namespace ProjetoBaltaPOO.ConteudoContexto
{
    public class Aula : EntidadeBase
    {
        public int OrdemDaAula { get; set; }
        public string Titulo { get; set; }
        public int DuracaoEmMinutos { get; set; }
        public EConteudoNivel Nivel { get; set; }
    }
}
