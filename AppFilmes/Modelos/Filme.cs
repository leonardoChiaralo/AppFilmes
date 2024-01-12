using System.Text.Json;
using System.Text.Json.Serialization;

namespace AppFilmes.Modelos;

internal class Filme
{
    [JsonPropertyName("title")]
    public string? Titulo { get; set; }

    [JsonPropertyName("year")]
    public string? Ano { get; set; }

    [JsonPropertyName("duration_min")]
    public int Duracao { get; set; }

    [JsonPropertyName("imDbRating")]
    public string? Nota { get; set; }

    [JsonPropertyName("crew")]
    public List<string> Elenco { get; set; } = new();

    [JsonIgnore]
    public string Detalhes => $"\nO filme {Titulo} foi lançado em {Ano}, com duração de {Duracao} minutos e avaliação {Nota} no IMDB.";


    public void ExibirElenco()
    {
        Console.WriteLine("\nElenco:");
        if (Elenco.Count > 0)
        {
            foreach (var artista in Elenco)
            {
                Console.WriteLine($"- {artista}");
            }
        }
        else
        {
            Console.WriteLine("------");
        }
    }

    public void GerarArquivoJson(List<Filme> filmes)
    {
        string json = JsonSerializer.Serialize(filmes);
        string nomeDoArquivo = $"movies.json";

        File.WriteAllText(nomeDoArquivo, json);
    }
}