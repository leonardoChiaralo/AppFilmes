namespace AppFilmes.Modelos;

class Artista
{
    public Artista(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public int Idade { get; set; }
    public string Detalhes => $"\n{Nome} tem {Idade} anos.";

    private List<Filme> filmesAtuados { get; set; } = new List<Filme>();

    public void AdicionarFilme(Filme filme)
    {
        filmesAtuados.Add(filme);
    }

    public void ExibirFilmesAtuados()
    {
        Console.WriteLine("\nFILMOGRAFIA:");
        if (filmesAtuados.Count > 0)
        {
            foreach (Filme filme in filmesAtuados)
            {
                Console.WriteLine($"{filme.Titulo};");
            }
        }
        else
        {
            Console.WriteLine("VAZIA");
        }

    }
}
