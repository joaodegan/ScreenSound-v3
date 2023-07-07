using System.Text.Json;
using ScreenSound_v3.Modelos;
using ScreenSound_v3.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "blues");
        //LinqOrder.ExibirListaDeArtistasaOrdernados(musicas);
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "U2");
        //LinqFilter.FiltrarMusicasPorAno(musicas, 2013);

        //var musicasPreferidas = new MusicasPreferidas("Joao");
        //musicasPreferidas.AdicionarMusicasFavoritas(musicas[1]);
        //musicasPreferidas.AdicionarMusicasFavoritas(musicas[2]);
        //musicasPreferidas.AdicionarMusicasFavoritas(musicas[3]);
        //musicasPreferidas.AdicionarMusicasFavoritas(musicas[4]);
        //musicasPreferidas.AdicionarMusicasFavoritas(musicas[5]);

        //musicasPreferidas.ExibirMusicasFavoritas();

        //musicasPreferidas.GerarArquivoJson();

        LinqFilter.FiltrarTodasAsMusicasQueTemOCsharp(musicas);

        //musicas[0].ExibirDetalhesDaMusica();

        

        Console.ReadKey();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}