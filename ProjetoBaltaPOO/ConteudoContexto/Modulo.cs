namespace ProjetoBaltaPOO.ConteudoContexto
{
    public class Modulo : EntidadeBase
    {
        public Modulo()
        {
            // inicializa a lista
            Aulas = new List<Aula>();
        }

        public int OrdemDoModulo { get; set; }
        public string Titulo { get; set; }
        public IList<Aula> Aulas { get; set; }
    }
}
