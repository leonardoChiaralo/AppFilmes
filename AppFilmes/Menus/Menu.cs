namespace AppFilmes.Menus;

internal class Menu
{
    public void ExibirTitulo(string titulo)
    {
        int quantidadeCaractere = titulo.Length;
        string asteriscos = string.Empty.PadLeft(quantidadeCaractere, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine($"{asteriscos}\n");
    }
}
