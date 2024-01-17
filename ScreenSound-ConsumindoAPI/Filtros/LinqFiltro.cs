using ScreenSound_ConsumindoAPI.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound_ConsumindoAPI.Filtros
{
    public class LinqFiltro
    {
        public static List<string?> FiltrarTodosGeneros(List<Musica2> musicas) => musicas.Select(x => x.Genero).Distinct().ToList();

        public static List<string?> ExibirListaDeArtistaOrdenado(List<Musica2> musicas, bool orderBy)
        {
            if (orderBy)
            {
                return musicas.OrderBy(x => x.Artista).Select(x => x.Artista).Distinct().ToList();
            }
            else
            {
                return musicas.OrderByDescending(x => x.Artista).Select(x => x.Artista).Distinct().ToList();
            }
        }

        public static List<string?> FiltrarArtitasPorGeneroMusical(List<Musica2> musicas, string genero) => musicas.Where(x => x.Genero!.Contains(genero)).Select(x => x.Artista).Distinct().ToList();

        public static List<string?> FiltrarMusicasDeUmArtista(List<Musica2> musicas, string nomeDoArtista) => musicas.Where(x => x.Artista!.Equals(nomeDoArtista)).Select(x => x.Nome).Distinct().ToList();
        
        public static void ExibirTudo(List<string> lista)
        {
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }
    }
}
    