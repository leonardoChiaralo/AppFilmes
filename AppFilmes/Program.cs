using AppFilmes.Menus;
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
Dictionary<int, Menu> opcoes = new();
opcoes.Add(0, new MenuSair());
opcoes.Add(1, new MenuExibirFilmes());
opcoes.Add(2, new MenuExibirArtistas());
opcoes.Add(3, new MenuRegistrarFilme());
opcoes.Add(4, new MenuRegistrarArtista());
opcoes.Add(5, new MenuAssociarArtistaAoFilme());
opcoes.Add(6, new MenuExibirElenco());
opcoes.Add(7, new MenuExibirFilmografia());
opcoes.Add(8, new MenuAvaliarFilme());

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

    if (opcoes.ContainsKey(opcaoEscolhida))
    {
        Menu menuASerExibido = opcoes[opcaoEscolhida];
        menuASerExibido.Executar(filmes, artistas);
        if (opcaoEscolhida > 0) ExibirMenu();
    } else
    {
        Console.Write("\nOpção inválida!");
    }
}

ExibirMenu();