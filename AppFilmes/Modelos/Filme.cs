namespace AppFilmes.Modelos;

class Filme
{
    public Filme(string titulo)
    {
        Titulo = titulo;
    }
    public string Titulo { get; }
    public double Duracao { get; set; }
    public double Media
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(a => a.Nota);
        }
    }
    public string Detalhes => $"\nO filme {Titulo} tem duração de {Duracao} minutos, com avaliação {Media}.";

    private List<Artista> elenco = new List<Artista>();
    private List<Avaliacao> notas = new List<Avaliacao>();

    public void AdicionarArtista(Artista artista)
    {
        elenco.Add(artista);
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public void ExibirElenco()
    {
        Console.WriteLine("\nELENCO:");
        if (elenco.Count > 0 )
        {
            foreach (Artista artista in elenco)
            {
                Console.WriteLine($"{artista.Nome};");
            }
        } else
        {
            Console.WriteLine("VAZIA");
        }
    }
}