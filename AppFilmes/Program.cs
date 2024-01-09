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
            MenuSair menu0 = new MenuSair();
            menu0.Executar();
            break;
        case 1:
            MenuExibirFilmes menu1 = new MenuExibirFilmes();
            menu1.Executar(filmes);
            ExibirMenu();
            break;
        case 2:
            MenuExibirArtistas menu2 = new MenuExibirArtistas();
            menu2.Executar(artistas);
            ExibirMenu();
            break;
        case 3:
            MenuRegistrarFilme menu3 = new MenuRegistrarFilme();
            menu3.Executar(filmes);
            ExibirMenu();
            break;
        case 4:
            MenuRegistrarArtista menu4 = new MenuRegistrarArtista();
            menu4.Executar(artistas);
            ExibirMenu();
            break;
        case 5:
            MenuAssociarArtistaAoFilme menu5 = new MenuAssociarArtistaAoFilme();
            menu5.Executar(filmes, artistas);
            ExibirMenu();
            break;
        case 6:
            MenuExibirElenco menu6 = new MenuExibirElenco();
            menu6.Executar(filmes);
            ExibirMenu();
            break;
        case 7:
            MenuExibirFilmografia menu7 = new MenuExibirFilmografia();
            menu7.Executar(artistas);
            ExibirMenu();
            break;
        case 8:
            MenuAvaliarFilme menu8 = new MenuAvaliarFilme();
            menu8.Executar(filmes);
            ExibirMenu();
            break;
        default:
            Console.Write("\nOpção inválida!");
            break;
    }
}

ExibirMenu();