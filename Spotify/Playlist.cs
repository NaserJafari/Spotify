using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class Playlist : Song
    {
        /*public Song[] songs;*/
        //public Album album;
        public List<Song> songs;
        public string nameOfPlaylist;
        public Artist artist;
        public Album album;

        public Playlist(string nameOfSong, string genreOfSong, int secondOfsong, int yearOfSong, Artist songOfArtist) 
        {
            artist = new Artist("dj");
            title = nameOfSong;
            genre = genreOfSong;
            seconds = secondOfsong;
            year = yearOfSong;
            artist = songOfArtist;
            
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

        //hier hoor je een song aan een playlist toe te voegen
        public void AddSongToPlaylist()
        {
            string whichPlaylist;
            string nameSong;
            string genreSong;
            int secondsOfSong;
            int yearOfSong;
            string artistOfSong;
            
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

        //met de fucntie kan de user een nieuwe playlist maken en daarin gelijk songs aanmaken.
        //maar dit werkt niet
        public void MakeNewPlaylist()
        {
            List<Song> nameOfPlaylist = new List<Song>();

            Console.WriteLine("Naam voor de nieuwe playlist?");
            string namePlaylist = Console.ReadLine();

            Console.WriteLine("titel van de song");
            string titleOfSong = Console.ReadLine();

            Console.WriteLine("genre van de song");
            string genreOfSong = Console.ReadLine();

            Console.WriteLine("hoeveel seconden is de song?");
            int secondsOfSong = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("wanneer kwam de song uit");
            int yearOfSong = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("van welke artiest");
            string artistOfSong = Console.ReadLine();

            Artist artist = new(artistOfSong);

            nameOfPlaylist.Add(new Song(titleOfSong, genreOfSong, secondsOfSong, yearOfSong, artist));

            foreach (var song in nameOfPlaylist)
            {
                Console.WriteLine(song);
            }
        }

        //met deze methode override ik de fields van de song klasse als een string
        public override string ToString()
        {
            return "Title: " + title + ", Genre:" + genre + ", Seconds: " + seconds + ", Year: " + year + " , Artist: " + artist;
        }
    }
}
