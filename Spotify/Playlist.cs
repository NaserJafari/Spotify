using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class Playlist
    {
        /*public Song[] songs;*/
        //public Album album;
        public List<Song> songs;
        public string name;

        public Playlist() 
        {
            //titel, genre, seconds, year, de naam van de artiest moet nog komen
            /* songs = new Song[]
             {
                 new Song("appelsap", "pop", 123, 2001),
                 new Song("bananensap", "b-pop", 132, 2002),
                 new Song("citroensap", "c-pop", 213, 2003),
                 new Song("druivensap", "d-pop", 231, 2004),
                 new Song("eurosap", "e-pop", 312, 2005),
             };*/

            songs = new List<Song>();
            songs.Add(new Song() { title = "appelsap", genre = "a-pop", seconds = 123, year = 2001 });
            songs.Add(new Song() { title = "banaansap", genre = "b-pop", seconds = 234, year = 2002 });
            songs.Add(new Song() { title = "citroensap", genre = "c-pop", seconds = 345, year = 2003 });
            songs.Add(new Song() { title = "druivensap", genre = "d-pop", seconds = 567, year = 2004 });
        }

        //hier moet je 
        public void ShowPlaylist()
        {
            for (int i = 0; i < songs.Count; i++)
            {
                Console.WriteLine(songs[i]);
            }
        }

        public void AddSongToPlaylist()
        {
            string whichPlaylist;
            string nameSong;
            string genreSong;
            int secondsOfSong;
            int yearOfSong;
            //Artiest moet nog komen
            
            Console.WriteLine("In welke playlist wil je de lied toevoegen");
            whichPlaylist = Console.ReadLine();
            Console.WriteLine("Welke lied wil je toevoegen?");
            Console.WriteLine("Titel van de song");
            nameSong = Console.ReadLine();

            Console.WriteLine("Genre van de song");
            genreSong = Console.ReadLine();

            Console.WriteLine("Hoeveel seconden is de song?");
            secondsOfSong = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Wanneer kwam de song uit?");
            yearOfSong = Convert.ToInt32(Console.ReadLine());

            songs.Add(new Song(nameSong, genreSong, secondsOfSong, yearOfSong));
        }

        public void MakeNewPlaylist()
        {
            string namePlaylist;
            Console.WriteLine("Naam voor de nieuwe playlist?");
            namePlaylist = Console.ReadLine();

            /*List<string> namePlaylist = new List<string>();*/

        }
    }
}
