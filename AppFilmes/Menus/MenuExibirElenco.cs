using AppFilmes.Modelos;

namespace AppFilmes.Menus;

internal class MenuExibirElenco : Menu
{
     public void Executar(Dictionary<string, Filme> filmes)
    {
        Console.Clear();
        ExibirTitulo("Exibição de elenco");
        Console.Write("Digite o nome do filme que deseja ver o elenco: ");
        string nomeFilme = Console.ReadLine()!;
        if (filmes.ContainsKey(nomeFilme))
        {
            Filme filme = filmes[nomeFilme];
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
