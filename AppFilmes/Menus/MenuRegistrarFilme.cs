using AppFilmes.Modelos;

namespace AppFilmes.Menus;

internal class MenuRegistrarFilme : Menu
{
    public void Executar(Dictionary<string, Filme> filmes)
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
    }
}
