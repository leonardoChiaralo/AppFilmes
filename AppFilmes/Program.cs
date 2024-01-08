using AppFilmes.Modelos;

Filme ronins = new("47 Ronins")
{
    Duracao = 119
};
Filme chihiro = new("A Viagem de Chihiro")
{
    Duracao = 125
};
Filme bladeRunner = new("Blade Runner")
{
    Duracao = 117
};
Filme constantine = new("Constantine")
{
    Duracao = 221
};
Filme logan = new("Logan")
{
    Duracao = 137
};

Artista sanada = new("Hiroyuki Sanada")
{
    Idade = 63
};
Artista hiiragi = new("Rumi Hiiragi")
{
    Idade = 36
};
Artista ford = new("Harrison Ford")
{
    Idade = 81
};
Artista reeves = new("Keanu Reeves")
{
    Idade = 59
};
Artista jackman = new("Hugh Jackman")
{
    Idade = 55
};

Dictionary<string, Filme> filmes = new();
Dictionary<string, Artista> artistas = new();

filmes.Add(ronins.Titulo, ronins);
filmes.Add(chihiro.Titulo, chihiro);
filmes.Add(bladeRunner.Titulo, bladeRunner);
filmes.Add(constantine.Titulo, constantine);
filmes.Add(logan.Titulo, logan);

artistas.Add(sanada.Nome, sanada);
artistas.Add(hiiragi.Nome, hiiragi);
artistas.Add(ford.Nome, ford);
artistas.Add(reeves.Nome, reeves);
artistas.Add(jackman.Nome, jackman);

ronins.AdicionarArtista(sanada);
ronins.AdicionarArtista(reeves);
sanada.AdicionarFilme(ronins);
reeves.AdicionarFilme(ronins);

chihiro.AdicionarArtista(hiiragi);
hiiragi.AdicionarFilme(chihiro);

bladeRunner.AdicionarArtista(ford);
ford.AdicionarFilme(bladeRunner);

constantine.AdicionarArtista(reeves);
reeves.AdicionarFilme(constantine);

logan.AdicionarArtista(jackman);
jackman.AdicionarFilme(logan);

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
    Console.WriteLine("Digite 1 para exibir a lista de filmes;");
    Console.WriteLine("Digite 2 para exibir a lista de artistas;");
    Console.WriteLine("Digite 3 para registrar um filme;");
    Console.WriteLine("Digite 4 para registrar um artista;");
    Console.WriteLine("Digite 5 para associar um artista a um filme;");
    Console.WriteLine("Digite 6 para exibir o elenco de um filme;");
    Console.WriteLine("Digite 7 para exibir a filmografia de um artista;");
    Console.WriteLine("Digite 8 para registrar uma nota a um filme;");
    Console.WriteLine("Digite 0 para sair.\n");

    Console.Write("Digita a opção escolhida: ");
    int opcaoEscolhida = int.Parse(Console.ReadLine()!);

    switch (opcaoEscolhida)
    {
        case 0:
            Console.WriteLine("\nSaindo...");
            break;
        case 1:
            ExibirFilmes();
            break;
        case 2:
            ExibirArtistas();
            break;
        case 3:
            RegistrarFilme();
            break;
        case 4:
            RegistrarArtista();
            break;
        case 5:
            AssociarArtistaAoFilme();
            break;
        case 6:
            ExibirElencoFilme();
            break;
        case 7:
            ExibirFilmografia();
            break;
        case 8:
            AvaliarFilme();
            break;
        default:
            Console.Write("\nOpção inválida!");
            break;
    }
}

void ExibirTitulo(string titulo)
{
    int quantidadeCaractere = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeCaractere, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine($"{asteriscos}\n");
}

void ExibirFilmes()
{
    Console.Clear();
    ExibirTitulo("Listagem de filmes");
    if (filmes.Count > 0)
    {
        foreach (Filme filme in filmes.Values)
        {
            Console.WriteLine($"Título: {filme.Titulo};");
        }
    }
    else
    {
        Console.WriteLine("Nenhum filme foi registrado!");
    }
    Console.Write("\nPressione qualquer tecla para voltar ao menu principal.");
    Console.ReadKey();
    Console.Clear();
    ExibirMenu();
}

void ExibirArtistas()
{
    Console.Clear();
    //Console.WriteLine("Listagem de artistas\n");
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
    ExibirMenu();
}

void RegistrarFilme()
{
    Console.Clear();
    ExibirTitulo("Registro de filmes");
    Console.Write("Digite o título do filme que deseja registrar: ");
    string tituloFilme = Console.ReadLine()!;
    Console.Write("Digite a duração do filme (minutos): ");
    double duracaoFilme = double.Parse(Console.ReadLine()!);
    if (filmes.ContainsKey(tituloFilme))
    {
        Console.WriteLine("\nEsse filme já foi registrado!");
    }
    else
    {
        Filme filme = new Filme(tituloFilme)
        {
            Duracao = duracaoFilme
        };
        filmes.Add(filme.Titulo, filme);
        Console.Write("\nFilme registrado com sucesso!");
    }
    Thread.Sleep(2000);
    Console.Clear();
    ExibirMenu();
}

void RegistrarArtista()
{
    Console.Clear();
    ExibirTitulo("Registro de artistas");
    Console.Write("Digite o nome do artista que deseja registrar: ");
    string nomeArtista = Console.ReadLine()!;
    Console.Write("Digite a idade do artista: ");
    int idadeArtista = int.Parse(Console.ReadLine()!);
    if (artistas.ContainsKey(nomeArtista))
    {
        Console.WriteLine("\nEsse artista já foi registrado!");
    }
    else
    {
        Artista artista = new Artista(nomeArtista)
        {
            Idade = idadeArtista
        };
        artistas.Add(artista.Nome, artista);
        Console.Write("\nArtista registrado com sucesso!");
    }
    Thread.Sleep(2000);
    Console.Clear();
    ExibirMenu();
}

void AssociarArtistaAoFilme()
{
    Console.Clear();
    ExibirTitulo("Associação de artistas a filmes");
    Console.Write("Digite o nome do filme que deseja associar um artista: ");
    string nomeFilme = Console.ReadLine()!;
    if (filmes.ContainsKey(nomeFilme))
    {
        Console.Write("Digite o nome do artista que deseja associar: ");
        string nomeArtista = Console.ReadLine()!;
        if (artistas.ContainsKey(nomeArtista))
        {
            Artista artista = artistas[nomeArtista];
            Filme filme = filmes[nomeFilme];
            filme.AdicionarArtista(new Artista(artista.Nome) { Idade = artista.Idade });
            artista.AdicionarFilme(new Filme(filme.Titulo) { Duracao = filme.Duracao });
            Console.Write("\nArtista associado com sucesso!");
        }
        else
        {
            Console.Write("\nEsse artista ainda não foi registrado!");
        }

    }
    else
    {
        Console.Write("\nEsse filme ainda não foi registrado!");
    }
    Thread.Sleep(2000);
    Console.Clear();
    ExibirMenu();
}

void ExibirElencoFilme()
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
        ExibirMenu();
    }
    else
    {
        Console.Write("\nEsse filme ainda não foi registrado!");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirMenu();
    }
}

void ExibirFilmografia()
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
        ExibirMenu();
    }
    else
    {
        Console.Write("\nEsse artista ainda não registrado!");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirMenu();
    }
}

void AvaliarFilme()
{
    Console.Clear();
    ExibirTitulo("Avaliação de filmes");
    Console.Write("Digite o nome do filme que deseja avaliar: ");
    string nomeFilme = Console.ReadLine()!;
    if (filmes.ContainsKey(nomeFilme))
    {
        Console.Write($"Digite uma para o filme {nomeFilme}: ");
        Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
        Filme filme = filmes[nomeFilme];
        filme.AdicionarNota(nota);
        Console.WriteLine("\nFilme avaliado com sucesso!");
    } else
    {
        Console.WriteLine("\nEsse filme ainda não foi registrado!");
    }

    Thread.Sleep(2000);
    Console.Clear();
    ExibirMenu();
}

ExibirMenu();