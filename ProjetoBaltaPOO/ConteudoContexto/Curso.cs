namespace ProjetoBaltaPOO.ConteudoContexto
{
    public class Curso : Conteudo
    {
        public string Tag { get; set; }
        public IList<Modulo> Modulos { get; set; }

        public Curso()
        {
            // inicializa a lista
            Modulos = new List<Modulo>();
        }
    }

    public class Modulo
    {
        public Modulo()
        {
            // inicializa a lista
            Aulas = new List<Aula>();
        }

        public int OrdemDoModulo { get; set; }
        public string Titulo { get; set; }
        public IList <Aula> Aulas { get; set; }
    }

    public class Aula
    {
        public int OrdemDaAula { get; set; }
        public string Titulo { get; set; }
    }
}
