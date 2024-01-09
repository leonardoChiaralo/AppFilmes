using AppFilmes.Modelos;

namespace AppFilmes.Menus;

internal class MenuExibirArtistas : Menu
{
    public override void Executar(Dictionary<string, Filme> filmes, Dictionary<string, Artista> artistas)
    {
        base.Executar(filmes, artistas);
        ExibirTitulo("Listagem de artistas");
        if (artistas.Count > 0)
        {
            foreach (Artista artista in artistas.Values)
            {
                Console.WriteLine($"Nome: {artista.Nome};");
            }
        }
        else
        {
            Console.WriteLine("Nenhum artista foi registrado!");
        }
        Console.Write("\nPressione qualquer tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
    }
}
