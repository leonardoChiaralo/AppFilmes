using AppFilmes.Menus;
using AppFilmes.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string filePathMovies = "C:\\Users\\leonardo.chiaralo\\Documents\\C# Alura\\C# projetos\\AppFilmes\\AppFilmes\\bin\\Debug\\net7.0\\movies.json";
        string respostaFilmes = await File.ReadAllTextAsync(filePathMovies);
        var filmes = JsonSerializer.Deserialize<List<Filme>>(respostaFilmes)!;

        string filePathArtists = "C:\\Users\\leonardo.chiaralo\\Documents\\C# Alura\\C# projetos\\AppFilmes\\AppFilmes\\bin\\Debug\\net7.0\\artists.json";
        string repostaArtistas = await File.ReadAllTextAsync(filePathArtists);
        var artistas = JsonSerializer.Deserialize<List<Artista>>(repostaArtistas)!;

        Dictionary<int, Menu> opcoes = new();
        opcoes.Add(0, new MenuSair());
        opcoes.Add(1, new MenuExibirFilmes());
        opcoes.Add(2, new MenuExibirArtistas());
        opcoes.Add(3, new MenuExibirDetalhesDoFilme());
        opcoes.Add(4, new MenuExibirFilmografia());
        opcoes.Add(5, new MenuRegistrarFilme());
        opcoes.Add(6, new MenuRegistrarArtista());
        opcoes.Add(7, new MenuAssociarArtistaAoFilme());

        void ExibirLogo()
        {
            Console.WriteLine(@"
███████╗██╗██╗░░░░░███╗░░░███╗░█████╗░░██████╗░██████╗░░█████╗░███████╗██╗██╗░░░░░███╗░░░███╗███████╗
██╔════╝██║██║░░░░░████╗░████║██╔══██╗██╔════╝░██╔══██╗██╔══██╗██╔════╝██║██║░░░░░████╗░████║██╔════╝
█████╗░░██║██║░░░░░██╔████╔██║██║░░██║██║░░██╗░██████╔╝███████║█████╗░░██║██║░░░░░██╔████╔██║█████╗░░
██╔══╝░░██║██║░░░░░██║╚██╔╝██║██║░░██║██║░░╚██╗██╔══██╗██╔══██║██╔══╝░░██║██║░░░░░██║╚██╔╝██║██╔══╝░░
██║░░░░░██║███████╗██║░╚═╝░██║╚█████╔╝╚██████╔╝██║░░██║██║░░██║██║░░░░░██║███████╗██║░╚═╝░██║███████╗
╚═╝░░░░░╚═╝╚══════╝╚═╝░░░░░╚═╝░╚════╝░░╚═════╝░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░░░░╚═╝╚══════╝╚═╝░░░░░╚═╝╚══════╝");
            Console.WriteLine("Bem vindo ao Filmografilme!\n");
        }

        void ExibirMenu()
        {
            ExibirLogo();
            Console.WriteLine("Digite 1 para exibir a lista de todos os filmes;");
            Console.WriteLine("Digite 2 para exibir a lista de todos os artistas;");
            Console.WriteLine("Digite 3 para exibir os detalhes de um filme;");
            Console.WriteLine("Digite 4 para exibir a filmografia de um artista;");
            Console.WriteLine("Digite 5 para registrar um filme na lista;");
            Console.WriteLine("Digite 6 para registrar um artista na lista;");
            Console.WriteLine("Digite 7 para associar um artista a um filme;");
            Console.WriteLine("Digite 0 para sair.\n");

            Console.Write("Digita a opção escolhida: ");
            int opcaoEscolhida = int.Parse(Console.ReadLine()!);

            if (opcoes.ContainsKey(opcaoEscolhida))
            {
                Menu menuASerExibido = opcoes[opcaoEscolhida];
                menuASerExibido.Executar(filmes, artistas);
                if (opcaoEscolhida > 0) ExibirMenu();
            }
            else
            {
                Console.Write("\nOpção inválida!");
            }
        }

        ExibirMenu();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}