using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ScreenSound_ConsumindoAPI.Models
{
    public class Musica2
    {
        [JsonPropertyName("song")]
        public string? Nome { get; set; }
        [JsonPropertyName("artist")]
        public string? Artista { get; set; }
        [JsonPropertyName("duration_ms")]
        public int Duracao { get; set; }
        [JsonPropertyName("genre")]
        public string? Genero { get; set; }
        [JsonPropertyName("key")]
        public int Key { get; set; }

        public void ExibirDetalhesDaMusica()
        {
            Console.WriteLine($"Artista: {this.Artista}");
            Console.WriteLine($"Musica: {this.Nome}");
            Console.WriteLine($"Duracao : {this.Duracao / 1000}(s)");
            Console.WriteLine($"Genero: {this.Genero}");
            Console.WriteLine($"Tonalidade: {this.Key}");

        }
    }
}
