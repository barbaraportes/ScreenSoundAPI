using ScreenSoundAPI.Modelos;

namespace ScreenSoundAPI.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();

        foreach ( var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo os artistas por gênero musical >>> {genero}");
        foreach(var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
        Console.WriteLine(nomeDoArtista);
        foreach(var musica in  musicasDoArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }

    public static void FiltrarMusicasPeloAno(List<Musica> musicas, int ano)
    {
        var musicasDoAno = musicas.Where(musica => musica.Ano == ano).OrderBy(musicas => musicas.Nome).Select(musicas => musicas.Nome).Distinct().ToList();

        Console.WriteLine($"Músicas de {ano}");

        foreach (var musica in musicasDoAno)
        {
            Console.WriteLine($"- {musica}");
        }
    }

    public static void FiltrarMusicasPorTonalidade(List<Musica> musicas, string tonalidade)
    {
        var musicasPorTonalidade = musicas.Where(musica => musica.Tonalidade!.Contains(tonalidade)).Select(musica => musica.Nome).Distinct().ToList();
        Console.WriteLine($"Exibindo as músicas pela tonalidade >>> {tonalidade}\n");
        foreach (var musica in musicasPorTonalidade)
        {
            Console.WriteLine($"- {musica}");
        }
    }

}
