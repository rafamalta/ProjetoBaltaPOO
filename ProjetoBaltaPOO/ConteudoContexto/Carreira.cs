namespace ProjetoBaltaPOO.ConteudoContexto
{
    public class Carreira : Conteudo
    {
        public IList<ItemCarreira> Itens { get; set; }

        // Expression body (propriedade retonando o 'get' com algum método)
        public int TotalDeCursos => Itens.Count;

        public Carreira(string titulo, string url) : base(titulo, url)
        {
            Itens = new List<ItemCarreira>();
        }
    }
}
