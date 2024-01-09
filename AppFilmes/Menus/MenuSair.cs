using AppFilmes.Modelos;

namespace AppFilmes.Menus;

internal class MenuSair : Menu
{
    public override void Executar(Dictionary<string, Filme> filmes, Dictionary<string, Artista> artistas)
    {
        Console.WriteLine("\nSaindo...");
    }
}
