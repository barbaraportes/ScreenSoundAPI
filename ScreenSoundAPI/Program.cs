using ScreenSoundAPI.Modelos;
using System.Text.Json;
using ScreenSoundAPI.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        //Console.WriteLine(resposta);
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //musicas[1].ExibirDetalhesDaMusica();
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "pop");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "U2");
        //LinqFilter.FiltrarMusicasPeloAno(musicas, 2012);
        //LinqFilter.FiltrarMusicasPorTonalidade(musicas, "C#");

        
        //var musicasPreferidasDaBarbara = new MusicasPreferidas("Barbara");
        //musicasPreferidasDaBarbara.AdicionarMusicasFavoritas(musicas[500]);
        //musicasPreferidasDaBarbara.AdicionarMusicasFavoritas(musicas[637]);
        //musicasPreferidasDaBarbara.AdicionarMusicasFavoritas(musicas[428]);
        //musicasPreferidasDaBarbara.AdicionarMusicasFavoritas(musicas[13]);
        //musicasPreferidasDaBarbara.AdicionarMusicasFavoritas(musicas[71]);

        //musicasPreferidasDaBarbara.ExibirMusicasFavoritas();

        //musicasPreferidasDaBarbara.GerarArquivoJson();

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }

    
}