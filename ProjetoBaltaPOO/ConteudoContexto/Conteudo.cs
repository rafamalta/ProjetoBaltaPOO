namespace ProjetoBaltaPOO.ConteudoContexto
{
    public abstract class Conteudo
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Url { get; set; }

        public Conteudo(string titulo, string url)
        {
            Id = Guid.NewGuid();
            Titulo = titulo;
            Url = url;
        }
    }
}
