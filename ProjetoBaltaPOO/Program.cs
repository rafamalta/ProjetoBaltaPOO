using ProjetoBaltaPOO.ConteudoContexto;

namespace ProjetoBaltaPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var artigo = new List<Artigo>();

            //artigo.Add(new Artigo("Artigo sobre OOP", "orientacao-objetos"));
            //artigo.Add(new Artigo("Artigo sobre C#", "c-sharp"));
            //artigo.Add(new Artigo("Artigo sobre .NET", "dotnet"));

            //foreach (var item in artigo)
            //{
            //    Console.WriteLine("-------------------");
            //    Console.WriteLine(item.Id);
            //    Console.WriteLine(item.Titulo);
            //    Console.WriteLine(item.Url);
            //}

            //Console.WriteLine("-------------------");

            var cursos = new List<Curso>();
            var cursoOOP = new Curso("Fundamentos OOP", "fundamentos-oop");
            var cursoCsharp = new Curso("Fundamentos C#", "fundamentos-csharp");
            var cursoAspNet = new Curso("Fundamentos ASP.NET", "fundamentos-aspnet");

            cursos.Add(cursoOOP);
            cursos.Add(cursoCsharp);
            cursos.Add(cursoAspNet);

            var carreiras = new List<Carreira>();
            var carreiraDotNet = new Carreira("Especialista .NET", "especialista-dotnet");
            var carreiraItem3 = new ItemCarreira(3, "Termine a carreira aqui", "", cursoAspNet);
            var carreiraItem1 = new ItemCarreira(1, "Comece a carreira por aqui", "", cursoCsharp);
            var carreiraItem2 = new ItemCarreira(2, "Continue a carreira por aqui", "", cursoOOP);
            carreiraDotNet.Itens.Add(carreiraItem3);
            carreiraDotNet.Itens.Add(carreiraItem1);
            carreiraDotNet.Itens.Add(carreiraItem2);
            carreiras.Add(carreiraDotNet);

            foreach (var carreira in carreiras)
            {
                Console.WriteLine(carreira.Titulo);
                Console.WriteLine(carreira.Url);
                foreach (var item in carreira.Itens.OrderBy(x => x.Pedido))
                {
                    Console.WriteLine($"{item.Pedido} - {item.Titulo}");
                    Console.WriteLine(item.Curso.Titulo);
                }
            }         

            Console.ReadKey();
        }
    }
}
