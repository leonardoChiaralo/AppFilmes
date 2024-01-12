using AppFilmes.Filtros;
using AppFilmes.Menus;
using AppFilmes.Modelos;

namespace AppFilmes.Menus;

internal class MenuExibirFilmes : Menu
{
    public override void Executar(List<Filme> filmes, List<Artista> artistas)
    {
        base.Executar(filmes, artistas);
        ExibirTitulo("Listagem de filmes");
        LinqOrder.OrdenarTodosFilmesPorTitulo(filmes);
    }
}
