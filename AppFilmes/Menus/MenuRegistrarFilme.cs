using AppFilmes.Menus;
using AppFilmes.Modelos;

namespace AppFilmes.Menus;

internal class MenuRegistrarFilme : Menu
{
    public override void Executar(List<Filme> filmes, List<Artista> artistas)
    {
        base.Executar(filmes, artistas);
        ExibirTitulo("Registro de filmes");
        Console.Write("Digite o título do filme que deseja registrar: ");
        string tituloFilme = Console.ReadLine()!;
        Console.Write("Digite o ano de lançamento do filme: ");
        string lancamentoFilme = Console.ReadLine()!;
        Console.Write("Digite a duração do filme (min.): ");
        int duracaoFilme = int.Parse(Console.ReadLine()!);
        Console.Write("Digite a nota do filme (IMDB): ");
        string notaFilme = Console.ReadLine()!;
        var todosTitulosFilmes = filmes.Select(filme => filme.Titulo).Distinct().ToList();
        if (todosTitulosFilmes.Contains(tituloFilme))
        {
            Console.Write("\nEsse filme já foi registrado!");
        }
        else
        {
            Filme filme = new()
            {
                Titulo = tituloFilme,
                Ano = lancamentoFilme,
                Duracao = duracaoFilme,
                Nota = notaFilme
            };
            filmes.Add(filme);
            filme.GerarArquivoJson(filmes);
            Console.Write("\nFilme registrado com sucesso!");
        }
        Thread.Sleep(2000);
        Console.Clear();
    }
}
