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
        public Song song;
        public Album album;
        public Playlist playlist;
        public Artist artist;
        public User user;
        
        public Client() 
        {
            artist = new Artist("dj");
            song = new Song();   
            album = new Album();
            playlist = new Playlist("titel", "genre", 123, 2001, artist);
            user = new User();
        }

        public void CheckUserInput()
        {
            Console.WriteLine("Wat wil je gaan doen in Spotify?");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {

            }
            else if (userInput == "2")
            {
                song = new Song("title", "genre", 123, 2001, artist);
                song.PlaySong();
            }
            else if (userInput == "3") 
            {
                song = new Song("title", "genre", 123, 2001, artist);
                song.DisplaySong();
            }
            else if (userInput == "4") 
            {
                playlist.ShowPlaylist();
            }
            else if (userInput == "5") 
            {
                playlist.ShowPlaylist();
                playlist.AddSongToPlaylist();
                playlist.ShowPlaylist();
            }
        }
    }
}
