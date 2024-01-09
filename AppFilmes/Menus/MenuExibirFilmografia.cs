using AppFilmes.Modelos;

namespace AppFilmes.Menus;

internal class MenuExibirFilmografia : Menu
{
    public override void Executar(Dictionary<string, Filme> filmes, Dictionary<string, Artista> artistas)
    {
        base.Executar(filmes, artistas);
        ExibirTitulo("Exibição da filmografia");
        Console.Write("Digite o nome do artista que deseja ver a filmografia: ");
        string nome = Console.ReadLine()!;
        if (artistas.ContainsKey(nome))
        {
            Artista artista = artistas[nome];
            artista.ExibirFilmesAtuados();
            Console.WriteLine(artista.Detalhes);
            Console.Write("\nPressione qualquer tecla para voltar ao menu principal.");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.Write("\nEsse artista ainda não foi registrado!");
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}
