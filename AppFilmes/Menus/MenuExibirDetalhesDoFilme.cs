using AppFilmes.Modelos;

namespace AppFilmes.Menus;

internal class MenuExibirDetalhesDoFilme : Menu
{
    public override void Executar(Dictionary<string, Filme> filmes, Dictionary<string, Artista> artistas)
    {
        base.Executar(filmes, artistas);
        ExibirTitulo("Exibição de elenco");
        Console.Write("Digite o nome do filme que deseja ver os detahes: ");
        string nomeFilme = Console.ReadLine()!;
        if (filmes.ContainsKey(nomeFilme))
        {
            Filme filme = filmes[nomeFilme];
            Console.WriteLine(filme.Detalhes);
            filme.ExibirElenco();
            Console.Write("\nPressione qualquer tecla para voltar ao menu principal.");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.Write("\nEsse filme ainda não foi registrado!");
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}
