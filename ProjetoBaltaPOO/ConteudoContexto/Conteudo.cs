namespace ProjetoBaltaPOO.ConteudoContexto
{
    public abstract class Conteudo
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Url { get; set; }

        public Conteudo()
        {
            Id = Guid.NewGuid();
        }
    }
}
