using AppFilmes.Filtros;
using AppFilmes.Menus;
using AppFilmes.Modelos;

namespace AppFilmes.Menus;

internal class MenuExibirDetalhesDoFilme : Menu
{
    public override void Executar(List<Filme> filmes, List<Artista> artistas)
    {
        base.Executar(filmes, artistas);
        ExibirTitulo("Exibição de detalhes");
        Console.Write("Digite o nome do filme que deseja ver os detalhes: ");
        string nomeFilme = Console.ReadLine()!;
        LinqFilter.FiltrarDetalhesDoFilme(filmes, nomeFilme);
    }
}
