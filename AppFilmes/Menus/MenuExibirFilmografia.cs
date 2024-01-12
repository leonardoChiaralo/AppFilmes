using AppFilmes.Filtros;
using AppFilmes.Menus;
using AppFilmes.Modelos;

namespace AppFilmes.Menus;

internal class MenuExibirFilmografia : Menu
{
    public override void Executar(List<Filme> filmes, List<Artista> artistas)
    {
        base.Executar(filmes, artistas);
        ExibirTitulo("Exibição da filmografia");
        Console.Write("Digite o nome do artista que deseja ver a filmografia: ");
        string nomeArtista = Console.ReadLine()!;
        LinqFilter.FiltrarDetalhesDoArtista(artistas, nomeArtista);
    }
}
