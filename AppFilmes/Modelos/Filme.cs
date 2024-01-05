namespace Alura.Filmes;

class Filme
{
    public Filme(string titulo)
    {
        Titulo = titulo;
    }
    public string Titulo { get; }
    public double Duracao { get; set; }
    public string Detalhes => $"O filme {Titulo} tem duração de {Duracao} minutos.";

    private List<Artista> elenco = new List<Artista>();

    public void AdicionarArtista(Artista artista)
    {
        elenco.Add(artista);
    }

    public void ExibirElenco()
    {
        Console.WriteLine("\nLISTA:");
        if (elenco.Count > 0 )
        {
            foreach (Artista artista in elenco)
            {
                Console.WriteLine($"Artista: {artista.Nome};\n{artista.Detalhes}\n");
            }
        } else
        {
            Console.WriteLine("VAZIA");
        }
    }
}