using System.Text.Json;
using System.Text.Json.Serialization;

namespace AppFilmes.Modelos;

internal class Artista
{
    [JsonPropertyName("name")]
    public string? Nome { get; set; }

    [JsonPropertyName("age")]
    public int Idade { get; set; }

    [JsonPropertyName("filmography")]
    public List<string> Filmografia { get; set; } = new();

    [JsonIgnore]
    public string? Detalhes => $"\n{Nome} tem {Idade} anos.";


    public void ExibirFilmografia()
    {
        Console.WriteLine("\nFilmografia:");
        if (Filmografia.Count > 0)
        {
            foreach (var filme in Filmografia)
            {
                Console.WriteLine($"- {filme}");
            }
        }
        else
        {
            Console.WriteLine("------");
        }
    }

    public void GerarArquivoJson(List<Artista> artistas)
    {
        string json = JsonSerializer.Serialize(artistas);
        string nomeDoArquivo = $"artists.json";

        File.WriteAllText(nomeDoArquivo, json);
    }
}
