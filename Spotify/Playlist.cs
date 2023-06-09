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
        public Artist artist;

        public Playlist() 
        {
            artist = new Artist("dj");

            songs = new List<Song>();
            songs.Add(new Song() { title = "appelsap", genre = "a-pop", seconds = 123, year = 2001, artist = artist });
            songs.Add(new Song() { title = "banaansap", genre = "b-pop", seconds = 234, year = 2002, artist = artist });
            songs.Add(new Song() { title = "citroensap", genre = "c-pop", seconds = 345, year = 2003, artist = artist });
            songs.Add(new Song() { title = "druivensap", genre = "d-pop", seconds = 567, year = 2004, artist = artist });

        }

        //met de functie kan je de in inhoud van de list zien
        public void ShowPlaylist()
        {
            for (int i = 0; i < songs.Count; i++)
            {
                Console.WriteLine(songs[i]);
            }
        }

        //hier kan je een song toevoegen aan list hierboevn ^^
        public void AddSongToPlaylist()
        {
            string whichPlaylist;
            string nameSong;
            string genreSong;
            int secondsOfSong;
            int yearOfSong;
            string artistOfSong;
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

            Console.WriteLine("Van welke artiest is de song?");
            artistOfSong = Console.ReadLine();
            Artist artist = new Artist(artistOfSong);
                    
            songs.Add(new Song(nameSong, genreSong, secondsOfSong, yearOfSong, artist));
        }

        public void MakeNewPlaylist()
        {
            Console.WriteLine("Naam voor de nieuwe playlist?");

            List<string> namePlaylist = new List<string>();

        }
    }
}
