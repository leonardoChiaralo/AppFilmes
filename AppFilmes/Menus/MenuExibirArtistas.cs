using AppFilmes.Modelos;

namespace AppFilmes.Menus;

internal class MenuExibirArtistas : Menu
{
    public void Executar(Dictionary<string, Artista> artistas)
    {
        Console.Clear();
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
