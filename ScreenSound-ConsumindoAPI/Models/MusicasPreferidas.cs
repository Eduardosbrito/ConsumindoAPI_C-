using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ScreenSound_ConsumindoAPI.Models
{
    public class MusicasPreferidas
    {

        public string Nome { get; set; }
        public List<Musica2> ListaDeMusicasFavoritas { get; }

        public MusicasPreferidas(string nome)
        {
            Nome = nome;
            ListaDeMusicasFavoritas = new List<Musica2>();
        }

        public void AdicionarMusicasFavoritas(Musica2 musicas)
        {
            ListaDeMusicasFavoritas.Add(musicas);
        }

        public void ExibirMusicasFavoritas()
        {
            Console.WriteLine($"Essas são as Musicas Favoritas: {this.Nome}");
            foreach (var musicas in ListaDeMusicasFavoritas)
            {
                Console.WriteLine($"- {musicas.Nome} de {musicas.Artista}");
            }
            Console.WriteLine("");
        }

        public void GerarArquivoJson()
        {
            string json = JsonSerializer.Serialize(new
            {
                nome = this.Nome,
                musicas =this.ListaDeMusicasFavoritas
            });

            string nomeArquivo = $"Musica-Favoritas-{this.Nome}.json";

            File.WriteAllText(nomeArquivo, json);
            Console.WriteLine($"Arquivo Json criado com sucesso! {Path.GetFullPath(nomeArquivo)}");
        }

        public void GerarDocumentoTXTComAsMusicasFavoritas()
        {
            string nomeDoArquivo = $"musicas-favoritas-{Nome}.txt";
            using (StreamWriter arquivo = new StreamWriter(nomeDoArquivo))
            {
                arquivo.WriteLine($"Músicas favoritas do {Nome}\n");
                foreach (var musica in this.ListaDeMusicasFavoritas)
                {
                    arquivo.WriteLine($"- {musica.Nome}");
                }
            }
            Console.WriteLine("txt gerado com sucesso!");
        }

    }
}
