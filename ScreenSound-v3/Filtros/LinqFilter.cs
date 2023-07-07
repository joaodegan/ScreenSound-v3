using ScreenSound_v3.Modelos;

namespace ScreenSound_v3.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        Console.WriteLine($"Genêros");
        var todosOsGenerosMusicais = musicas.Select(m => m.Genero).Distinct().ToList();
        foreach(var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        Console.WriteLine($"Artistas por gênero musical >>> {genero}");
        var artistasPorGeneroMusical = musicas.Where(m => m.Genero!.Contains(genero)).Select(m => m.Artista).Distinct().ToList();
        foreach (var artist in artistasPorGeneroMusical) {
            Console.WriteLine($"- {artist}");
        }
    }

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string artista)
    {
        Console.WriteLine($"O artista {artista} tem essas músicas disponíveis");
        var musicasDoArtista = musicas.Where(m => m.Artista!.Equals(artista)).ToList();
        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }

    public static void FiltrarMusicasPorAno(List<Musica> musicas, int ano)
    {
        Console.WriteLine($"As músicas filtradas pelo ano de {ano} são:");
        var musicasDoAno = musicas.Where(m => m.Ano == ano).OrderBy(m => m.Nome).Select(m => m.Nome).Distinct().ToList();
        foreach (var musica in musicasDoAno)
        {
            Console.WriteLine($"- {musica}");
        }
        
    }

    public static void FiltrarTodasAsMusicasQueTemOCsharp(List<Musica> musicas)
    {
        Console.WriteLine($"Tonalidade C#");
        var musicasCsharp = musicas.Where(m => m.Tonalidade.Equals("C#")).Select(m => m.Nome).Distinct().ToList();
        foreach (var musica in musicasCsharp)
        {
            Console.WriteLine($"- {musica}");
        }
    }
}
