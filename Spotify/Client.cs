using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class Client
    {
        public Song song; //instantie van de Song klasse
        public Album album; //instantie van de Album klasse
        public Playlist playlist; //instantie van de PLaylist klasse
        public Artist artist; //instantie van de Artist klasse
        public User user; //instantie van de User klasse
        
        //constructor zonder parameter, maar ik kan wel nieuwe Client objecten maken
        public Client() 
        {
            artist = new Artist("dj"); //hier maak ik een nieuwe artist object aan 
            song = new Song(); //hier maak ik een nieuwe song object aan
            album = new Album(); //hier maak ik een nieuwe album object aan
            playlist = new Playlist("titel", "genre", 123, 2001, artist); //hier initialiseer ik de playlist klasse met hardcoded waardes
            user = new User(); //hier maak ik een nieuwe user object aan
        }

        //deze functie checkt de input van de user en doet vervolgens de actie die erbij hoort
        public void CheckUserInput()
        {
            Console.WriteLine("Wat wil je gaan doen in Spotify?");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {

            }
            else if (userInput == "2")
            {
                //bij deze actie maakt hij een nieuwe song object en gaat hij die song afspelen van de song functie
                song = new Song("title", "genre", 123, 2001, artist);
                song.PlaySong();
            }
            else if (userInput == "3") 
            {
                //bij deze actie maakt hij een nieuwe song object en displayed hij de fields van de song klasse
                song = new Song("title", "genre", 123, 2001, artist);
                song.DisplaySong();
            }
            else if (userInput == "4") 
            {
                //deze actie laat de inhoud van de hardcoded playlist klasse zien
                playlist.ShowPlaylist();
            }
            else if (userInput == "5") 
            {
                //deze actie laat de inhoud van de hardcoded playlist klasse zien
                //daarna gaat het naar de functie om een song te kunnen toevoegen aan de hardcoded klasse
                //daarna laat hij de aangepaste playlist klasse zien met de nieuwe toegevoegde song
                playlist.ShowPlaylist();
                playlist.AddSongToPlaylist();
                playlist.ShowPlaylist();
            }
        }
    }
}
