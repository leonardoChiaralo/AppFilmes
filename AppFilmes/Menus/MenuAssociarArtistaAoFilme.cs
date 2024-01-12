using AppFilmes.Filtros;
using AppFilmes.Menus;
using AppFilmes.Modelos;

namespace AppFilmes.Menus;

internal class MenuAssociarArtistaAoFilme : Menu
{
    public override void Executar(List<Filme> filmes, List<Artista> artistas)
    {
        base.Executar(filmes, artistas);
        ExibirTitulo("Associação de artistas a filmes");
        Console.Write("Digite o nome do filme que deseja associar um artista: ");
        string nomeFilme = Console.ReadLine()!;
        var todosTitulosFilmes = filmes.Select(filme => filme.Titulo).Distinct().ToList();
        if (todosTitulosFilmes.Contains(nomeFilme))
        {
            Console.Write($"Digite o nome do artista que deseja associar ao filme {nomeFilme}: ");
            string nomeArtista = Console.ReadLine()!;
            var todosNomesArtistas = artistas.Select(artista => artista.Nome).Distinct().ToList();
            if (todosNomesArtistas.Contains(nomeArtista))
            {
                LinqFilter.FiltrarElencoPorTitulo(filmes, nomeFilme, nomeArtista);
                LinqFilter.FiltrarFilmografiaPorNome(artistas, nomeFilme, nomeArtista);
            }
            else
            {
                Console.WriteLine("\nEsse artista ainda não foi registrado!");
                Thread.Sleep(2000);
                Console.Clear();
            }
        }
        else
        {
            Console.Write("\nEsse filme ainda não foi registrado!");
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}
