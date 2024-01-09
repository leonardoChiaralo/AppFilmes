using AppFilmes.Modelos;

namespace AppFilmes.Menus;

internal class MenuAssociarArtistaAoFilme : Menu
{
    public override void Executar(Dictionary<string, Filme> filmes, Dictionary<string, Artista> artistas)
    {
        base.Executar(filmes, artistas);
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
    }
}
