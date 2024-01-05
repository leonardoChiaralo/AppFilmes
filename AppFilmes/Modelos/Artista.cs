namespace Alura.Filmes;

class Artista
{
    public Artista(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public int Idade { get; set; }
    public string Detalhes => $"O artista {Nome} tem {Idade} anos.";

    private List<Filme> filmesAtuados { get; set; } = new List<Filme>();

    public void AdicionarFilme(Filme filme)
    {
        filmesAtuados.Add(filme);
    }

    public void ExibirFilmesAtuados()
    {
        Console.WriteLine("\nLISTA:");
        if (filmesAtuados.Count > 0)
        {
            foreach (Filme filme in filmesAtuados)
            {
                Console.WriteLine($"Filme: {filme.Titulo};\n{filme.Detalhes}\n");
            }
        }
        else
        {
            Console.WriteLine("VAZIA");
        }

    }
}
