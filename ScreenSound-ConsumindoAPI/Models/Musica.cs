using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound_ConsumindoAPI.Models
{
    public class Musica
    {
        public string? artist { get; set; }
        public string? song { get; set; }
        public int duration_ms { get; set; }
        public string? @explicit { get; set; }
        public string? year { get; set; }
        public string? popularity { get; set; }
        public string? danceability { get; set; }
        public string? energy { get; set; }
        public int key { get; set; }
        public string? loudness { get; set; }
        public string? mode { get; set; }
        public string? speechiness { get; set; }
        public string? acousticness { get; set; }
        public string? instrumentalness { get; set; }
        public string? liveness { get; set; }
        public string? valence { get; set; }
        public string? tempo { get; set; }
        public string? genre { get; set; }
    }
}
