using AppFilmes.Modelos;

namespace AppFilmes.Menus;

internal class MenuRegistrarArtista : Menu
{
    public void Executar(Dictionary<string, Artista> artistas)
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
    }
}
