using AppFilmes.Modelos;

namespace AppFilmes.Menus;

internal class Menu
{
    public void ExibirTitulo(string titulo)
    {
        int quantidaeCaractere = titulo.Length;
        string asteriscos = string.Empty.PadLeft(quantidaeCaractere, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine($"{asteriscos}\n");
    }

    public virtual void Executar(List<Filme> filmes, List<Artista> artistas)
    {
        Console.Clear();
    }
}
