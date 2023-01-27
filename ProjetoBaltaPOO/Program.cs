using ProjetoBaltaPOO.ConteudoContexto;

namespace ProjetoBaltaPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var artigo = new List<Artigo>();

            artigo.Add(new Artigo("Artigo sobre OOP", "orientacao-objetos"));
            artigo.Add(new Artigo("Artigo sobre C#", "c-sharp"));
            artigo.Add(new Artigo("Artigo sobre .NET", "dotnet"));

            foreach (var item in artigo)
            {
                Console.WriteLine("-------------------");
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Titulo);
                Console.WriteLine(item.Url);
            }
            Console.WriteLine("-------------------");

            Console.ReadKey();
        }
    }
}
