using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class Playlist : Song //hier inherit ik de song klasse fields 
    {
        public List<Song> songs; //instantie van de Song klasse in een list
        public string nameOfPlaylist; //field voor een naam van een playlist
        public Artist artist; //instantie van de Artist klasse
        public Album album; //instantie van de Album klasse

        //een constructor met meerdere parameters, hier zie je dat ik de tot met yearOfSong de fields inherit van de song klasse
        //en de songOfArtist een nieuwe instantie maakt
        public Playlist(string nameOfSong, string genreOfSong, int secondOfsong, int yearOfSong, Artist songOfArtist) 
        {
            //hier initialiseer ik de waardes en maak ik een nieuwe artist object met de naam van de artiest als parameter van de artist klasse
            artist = new Artist("dj"); 
            title = nameOfSong;
            genre = genreOfSong;
            seconds = secondOfsong;
            year = yearOfSong;
            artist = songOfArtist;
            
            //hier initialiseer ik de waardes van de songs field list
            songs = new List<Song>();
            songs.Add(new Song() { title = "appelsap", genre = "a-pop", seconds = 123, year = 2001, artist = artist });
            songs.Add(new Song() { title = "banaansap", genre = "b-pop", seconds = 234, year = 2002, artist = artist });
            songs.Add(new Song() { title = "citroensap", genre = "c-pop", seconds = 345, year = 2003, artist = artist });
            songs.Add(new Song() { title = "druivensap", genre = "d-pop", seconds = 567, year = 2004, artist = artist });

        }

        //met de functie kan je de in inhoud van de list zien
        public void ShowPlaylist()
        {
            for (int i = 0; i < songs.Count; i++) //een forloop die door de list songs heen gaat en de data ervan logged
            {
                Console.WriteLine(songs[i]);
            }
        }

        //hier hoor je een song aan een playlist toe te voegen
        public void AddSongToPlaylist()
        {
            //hier initialiseer ik de variabelen voor de inputs
            string whichPlaylist;
            string nameSong;
            string genreSong;
            int secondsOfSong;
            int yearOfSong;
            string artistOfSong;
            
            //hier moet je een playlist kunnen kiezen om aan de goeie playlist een song toe te kunnen voegen
            Console.WriteLine("In welke playlist wil je de lied toevoegen");
            whichPlaylist = Console.ReadLine();

            Console.WriteLine("Welke lied wil je toevoegen?");

            //hier pak ik de user inputs en stop ze in de variabelen, als dat gelukt is, dan voeg je een nieuwe song toe aan de hardcoded playlist

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
            //hier maak ik een nieuwe object van de artist klasse van de user input voor de name parameter van de artist klasse
            Artist artist = new Artist(artistOfSong);
                    
            //hier voeg ik de nieuwe song dan toe
            songs.Add(new Song(nameSong, genreSong, secondsOfSong, yearOfSong, artist));
        }

        //met de fucntie kan de user een nieuwe playlist maken en daarin gelijk songs aanmaken.
        public void MakeNewPlaylist()
        {
            //hier maakt je een nieuwe song object en zet dat in een lijst.
            List<Song> nameOfPlaylist = new List<Song>();

            //hier pak ik de user inputs en stop ze in de variabelen om een nieuwe song object te maken en dat in een nieuwe lijst te stoppen
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

            //hier maak ik een nieuwe object artiest met de user input voor de name paremeter van de artist klasse
            Artist artist = new(artistOfSong);

            //hier voeg ik de inputs van de user toe aan de nieuwe playlilst
            nameOfPlaylist.Add(new Song(titleOfSong, genreOfSong, secondsOfSong, yearOfSong, artist));

            //een foreach die de inhoud van de nieuwePLaylist moet gaan loggen
            foreach (var song in nameOfPlaylist)
            {
                Console.WriteLine(song);
            }
        }

        //met deze methode override ik de fields van de inherited song klasse naar een string
        public override string ToString()
        {
            return "Title: " + title + ", Genre:" + genre + ", Seconds: " + seconds + ", Year: " + year + " , Artist: " + artist;
        }
    }
}
