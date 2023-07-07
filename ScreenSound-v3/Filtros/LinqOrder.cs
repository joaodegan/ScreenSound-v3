using ScreenSound_v3.Modelos;

namespace ScreenSound_v3.Filtros;

internal class LinqOrder
{
    public static void ExibirListaDeArtistasaOrdernados(List<Musica> musicas)
    {
        var artistasOrdernados = musicas.OrderBy(m => m.Artista).Select(m => m.Artista).Distinct().ToList();
        Console.WriteLine("Lista de artistas ordenados");
        foreach(var artist in artistasOrdernados)
        {
            Console.WriteLine($"- {artist}");
        }
    }
}
