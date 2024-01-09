using AppFilmes.Modelos;

namespace AppFilmes.Menus;

internal class MenuAvaliarFilme : Menu
{
    public void Executar(Dictionary<string, Filme> filmes)
    {
        Console.Clear();
        ExibirTitulo("Avaliação de filmes");
        Console.Write("Digite o nome do filme que deseja avaliar: ");
        string nomeFilme = Console.ReadLine()!;
        if (filmes.ContainsKey(nomeFilme))
        {
            Console.Write($"Digite uma nota para o filme {nomeFilme}: ");
            Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
            Filme filme = filmes[nomeFilme];
            filme.AdicionarNota(nota);
            Console.Write("\nFilme avaliado com sucesso!");
        }
        else
        {
            Console.WriteLine("\nEsse filme ainda não foi registrado!");
        }

        Thread.Sleep(2000);
        Console.Clear();
    }
}
