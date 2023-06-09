using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class Album
    {
        public string name;
        public Song[] song;
        public Artist artist;

        public Album() 
        {
            artist = new Artist("dj");

            song = new Song[]
            {
                new Song("ablbum", "pop", 321, 200112, artist),
                new Song("bblum", "b-pop", 123, 20028923, artist),
                new Song("cblum", "c-pop", 123, 200756, artist),
                new Song("dblum", "d-pop", 123, 20123, artist),
                new Song("edblum", "e-pop", 123, 20019, artist),
            }; 
        }

        public void ShowAlbum()
        {
            for (int i  = 0; i < song.Length; i++) 
            {
                Console.WriteLine(song[i]);
            }
        }
    }
}
