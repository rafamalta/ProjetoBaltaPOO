using ProjetoBaltaPOO.ConteudoContexto;

namespace ProjetoBaltaPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var carreira = new Carreira();

            carreira.Itens.Add(new ItemCarreira());
            Console.WriteLine(carreira.TotalDeCursos);

            Console.ReadKey();
        }
    }
}
