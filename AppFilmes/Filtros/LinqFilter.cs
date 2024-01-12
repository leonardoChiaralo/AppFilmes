using AppFilmes.Modelos;

namespace AppFilmes.Filtros;

internal class LinqFilter
{
    public static void FiltrarElencoPorTitulo(List<Filme> filmes, string nomeFilme, string nomeArtista)
    {
        var elencoPorTitulo = filmes.Where(filme => filme.Titulo!.Contains(nomeFilme)).Select(filme => filme.Elenco).Distinct().ToList();
        foreach (var elenco in elencoPorTitulo)
        {
            if (elenco.Contains(nomeArtista))
            {
                Console.Write("\nEsse artista já está associado a este filme!");
                break;
            }
            else
            {
                elenco.Add(nomeArtista);
                Filme filme = new Filme();
                filme.GerarArquivoJson(filmes);
                Console.Write($"\n{nomeArtista} associado com sucesso ao filme {nomeFilme}!");
                break;
            }
        }
        Thread.Sleep(2000);
        Console.Clear();
    }

    public static void FiltrarFilmografiaPorNome(List<Artista> artistas, string nomeFilme, string nomeArtista)
    {
        var filmografiaPorNome = artistas.Where(artista => artista.Nome!.Contains(nomeArtista)).Select(artista => artista.Filmografia).Distinct().ToList();
        foreach (var filmografia in filmografiaPorNome)
        {
            if (filmografia.Contains(nomeFilme))
            {
                break;
            }
            else
            {
                filmografia.Add(nomeFilme);
                Artista artista = new();
                artista.GerarArquivoJson(artistas);
                break;
            }
        }
    }

    public static void FiltrarDetalhesDoFilme(List<Filme> filmes, string nomeFilme)
    {
        var todosTitulosFilmes = filmes.Select(filme => filme.Titulo).Distinct().ToList();
        bool filmeEncontrado = false;
        foreach (var titulo in todosTitulosFilmes)
        {
            if (titulo == nomeFilme)
            {
                Filme filmeFiltrado = filmes.FirstOrDefault(filme => filme.Titulo!.Equals(nomeFilme, StringComparison.OrdinalIgnoreCase))!;
                Console.WriteLine(filmeFiltrado.Detalhes);
                filmeFiltrado.ExibirElenco();
                Console.Write("\nPressione qualquer tecla para voltar ao menu principal.");
                Console.ReadKey();
                Console.Clear();
                filmeEncontrado = true;
                break;
            }
        }

        if (!filmeEncontrado)
        {
            Console.WriteLine("\nEsse filme não foi encontrado!");
            Thread.Sleep(2000);
            Console.Clear();
        }
    }

    public static void FiltrarTodosElencos(List<Filme> filmes)
    {
        var todosElencoFilmes = filmes.Select(filme => filme.Elenco).Distinct().ToList();
        if (todosElencoFilmes.Count > 0)
        {
            foreach (var elenco in todosElencoFilmes)
            {
                foreach (var artista in elenco)
                {
                    Console.WriteLine($"- {artista}");
                }
            }
            Console.Write("\nPressione qualquer tecla para voltar ao menu principal.");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine("\nNenhum artista foi encontrado!");
            Thread.Sleep(2000);
            Console.Clear();
        }
    }

    public static void FiltrarTitulosPorArtista(List<Filme> filmes, string nomeArtista)
    {
        var todosElencoFilmes = filmes.Select(filme => filme.Elenco).Distinct().ToList();
        foreach (var elenco in todosElencoFilmes)
        {
            if (elenco.Contains(nomeArtista))
            {
                var titulosPorArtista = filmes.Where(filme => filme.Elenco.Contains(nomeArtista)).Select(filme => filme.Titulo).Distinct().ToList();
                Console.WriteLine("\nFilmografia:");
                if (titulosPorArtista.Count > 0)
                {
                    foreach (var titulo in titulosPorArtista)
                    {
                        Console.WriteLine($"- {titulo}");
                    }
                    Console.Write("\nPressione qualquer tecla para voltar ao menu principal.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine("------");
                    Console.Write("\nPressione qualquer tecla para voltar ao menu principal.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }
            }
            else
            {
                Console.WriteLine("\nEsse artista não foi encontrado!");
                Thread.Sleep(2000);
                Console.Clear();
                break;
            }
        }
    }

    public static void FiltrarDetalhesDoArtista(List<Artista> artistas, string nomeArtista)
    {
        var todosNomesArtistas = artistas.Select(artista => artista.Nome).Distinct().ToList();
        bool artistaEncontrado = false;
        foreach (var nome in todosNomesArtistas)
        {
            if (nome == nomeArtista)
            {
                Artista artistaFiltrado = artistas.FirstOrDefault(artista => artista.Nome!.Equals(nomeArtista, StringComparison.OrdinalIgnoreCase))!;
                Console.WriteLine(artistaFiltrado.Detalhes);
                artistaFiltrado.ExibirFilmografia();
                Console.Write("\nPressione qualquer tecla para voltar ao menu principal.");
                Console.ReadKey();
                Console.Clear();
                artistaEncontrado = true;
                break;
            }
        }

        if (!artistaEncontrado)
        {
            Console.Write("\nEsse artista não foi encontrado!");
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}
