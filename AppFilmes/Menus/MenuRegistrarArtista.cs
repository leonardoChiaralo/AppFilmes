using AppFilmes.Menus;
using AppFilmes.Modelos;

namespace AppFilmes.Menus;

internal class MenuRegistrarArtista : Menu
{
    public override void Executar(List<Filme> filmes, List<Artista> artistas)
    {
        base.Executar(filmes, artistas);
        ExibirTitulo("Registro de artistas");
        Console.Write("Digite o nome do artista que deseja registrar: ");
        string nomeArtista = Console.ReadLine()!;
        Console.Write("Digite a idade do artista: ");
        int idadeArtista = int.Parse(Console.ReadLine()!);
        var todosNomesArtistas = artistas.Select(artista => artista.Nome).Distinct().ToList();
        if (todosNomesArtistas.Contains(nomeArtista))
        {
            Console.Write("\nEsse artista já foi registrado!");
        }
        else
        {
            Artista artista = new()
            {
                Nome = nomeArtista,
                Idade = idadeArtista
            };
            artistas.Add(artista);
            artista.GerarArquivoJson(artistas);
            Console.Write("\nArtista registrado com sucesso!");
        }
        Thread.Sleep(2000);
        Console.Clear();
    }
}
