using AppFilmes.Filtros;
using AppFilmes.Menus;
using AppFilmes.Modelos;

namespace AppFilmes.Menus;

internal class MenuExibirArtistas : Menu
{
    public override void Executar(List<Filme> filmes, List<Artista> artistas)
    {
        base.Executar(filmes, artistas);
        ExibirTitulo("Listagem de artistas");
        LinqOrder.OrdenarTodosArtistasPorNome(artistas);
    }
}
