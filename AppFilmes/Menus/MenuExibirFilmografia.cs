using AppFilmes.Modelos;

namespace AppFilmes.Menus;

internal class MenuExibirFilmografia : Menu
{
    public void Executar(Dictionary<string, Artista> artistas)
    {
        Console.Clear();
        ExibirTitulo("Exibição da filmografia");
        Console.Write("Digite o nome do artista que deseja ver a filmografia: ");
        string nome = Console.ReadLine()!;
        if (artistas.ContainsKey(nome))
        {
            Artista artista = artistas[nome];
            artista.ExibirFilmesAtuados();
            Console.Write("\nPressione qualquer tecla para voltar ao menu principal.");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.Write("\nEsse artista ainda não registrado!");
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}
