using AppFilmes.Modelos;

namespace AppFilmes.Filtros;

internal class LinqOrder
{
    public static void OrdenarTodosFilmesPorTitulo(List<Filme> filmes)
    {
        if (filmes.Count > 0)
        {
            var todosTitulosFilmes = filmes.OrderBy(filme => filme.Titulo).Select(filme => filme.Titulo).Distinct().ToList();
            foreach (var titulo in todosTitulosFilmes)
            {
                Console.WriteLine($"- {titulo}");
            }
            Console.Write("\nPressione qualquer tecla para voltar ao menu principal.");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine("Nenhum filme foi encontrado!");
            Thread.Sleep(2000);
            Console.Clear();
        }
    }

    public static void OrdenarTodosArtistasPorNome(List<Artista> artistas)
    {
        if (artistas.Count > 0)
        {
            var todosNomesArtistas = artistas.OrderBy(artista => artista.Nome).Select(artista => artista.Nome).Distinct().ToList();
            foreach (var nome in todosNomesArtistas)
            {
                Console.WriteLine($"- {nome}");
            }
            Console.Write("\nPressione qualquer tecla para voltar ao menu principal.");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.Write("Nenhum artista foi encontrado!");
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}
