namespace ProjetoBaltaPOO.ConteudoContexto
{
    public class ItemCarreira
    {
        public int Pedido { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public Curso Curso { get; set; }

        public ItemCarreira(int pedido, string titulo, string descricao, Curso curso)
        {
            Pedido = pedido;
            Titulo = titulo;
            Descricao = descricao;
            Curso = curso;
        }
    }
}
