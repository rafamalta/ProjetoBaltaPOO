using ProjetoBaltaPOO.ConteudoContexto.Enums;

namespace ProjetoBaltaPOO.ConteudoContexto
{
    public class Aula
    {
        public int OrdemDaAula { get; set; }
        public string Titulo { get; set; }
        public int DuracaoEmMinutos { get; set; }
        public EConteudoNivel Nivel { get; set; }
    }
}
