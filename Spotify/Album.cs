using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class Album
    {
        public string name; //field om de album een naam te geven
        public Song[] song; //instantie van de Song klasse in een array, dus de fields van de song klasse 
        public Artist artist; //instantie van de Artist klasse

        public Album() 
        {
            //een instantie van de artist klasse, door de constructor van artist klasse, kan ik de songs een artiest naam geven
            //in dit geval geef ik deze artiest de naam als "dj"
            artist = new Artist("dj");

            //hier declareer ik de song field en geef ik hardcoded songs mee
            song = new Song[]
            {
                //paar songs gedeclareed van de song klasse
                new Song("ablbum", "pop", 321, 200112, artist),
                new Song("bblum", "b-pop", 123, 20028923, artist),
                new Song("cblum", "c-pop", 123, 200756, artist),
                new Song("dblum", "d-pop", 123, 20123, artist),
                new Song("edblum", "e-pop", 123, 20019, artist),
            }; 
        }

        //met de methode kan je de inhoud van de album inzien
        //dus de titel van een song, de geren, hoelang een song is, wanneer die uitkwam en van welke artiest
        public void ShowAlbum()
        {
            for (int i  = 0; i < song.Length; i++)//een for loop om de inhoud van de array loggen
            {
                Console.WriteLine(song[i]);
            }
        }
    }
}
