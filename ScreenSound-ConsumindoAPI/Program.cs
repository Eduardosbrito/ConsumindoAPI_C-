


using ScreenSound_ConsumindoAPI.Filtros;
using ScreenSound_ConsumindoAPI.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

using (HttpClient client = new HttpClient())
{
	try
	{
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        
		var musica = JsonSerializer.Deserialize<List<Musica>>(resposta);
        var musica2 = JsonSerializer.Deserialize<List<Musica2>>(resposta);

        var generos = LinqFiltro.FiltrarTodosGeneros(musica2);

        var artistaAsc = LinqFiltro.ExibirListaDeArtistaOrdenado(musica2, true);

        var artistaDesc = LinqFiltro.ExibirListaDeArtistaOrdenado(musica2, false);

        var artistaGenero = LinqFiltro.FiltrarArtitasPorGeneroMusical(musica2, "rock");

        var NomeMusica = LinqFiltro.FiltrarMusicasDeUmArtista(musica2, "Tyga");

        var musicaPreferidas = new MusicasPreferidas("Daniel");
        musicaPreferidas.AdicionarMusicasFavoritas(musica2[0]);
        musicaPreferidas.AdicionarMusicasFavoritas(musica2[1]);
        musicaPreferidas.AdicionarMusicasFavoritas(musica2[2]);
        musicaPreferidas.AdicionarMusicasFavoritas(musica2[3]);
        musicaPreferidas.AdicionarMusicasFavoritas(musica2[4]);

        musicaPreferidas.ExibirMusicasFavoritas();

        //musicaPreferidas.GerarArquivoJson();

        musicaPreferidas.GerarDocumentoTXTComAsMusicasFavoritas();

        //LinqFiltro.ExibirTudo(NomeMusica);

        //musica2[0].ExibirDetalhesDaMusica();
    }
    catch (Exception ex)
	{
		Console.WriteLine($"Temos um problema: {ex.Message}");
	}
};