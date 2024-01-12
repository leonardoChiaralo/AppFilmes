using AppFilmes.Modelos;

namespace AppFilmes.Menus;

internal class MenuSair : Menu
{
    public override void Executar(List<Filme> filmes, List<Artista> artistas)
    {
        Console.WriteLine("\nSaindo...");
    }
}
