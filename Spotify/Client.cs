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
        
        public Client() 
        {
            song = new Song();   
            album = new Album();
            playlist = new Playlist();
        }

        public void CheckUserInput()
        {
            Console.WriteLine("Wat wil je gaan doen in Spotify?");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                song = new Song("title", "genre", 123, 2001);
                song.PlaySong();
            }
            else if (userInput == "2") 
            {
                song = new Song("title", "genre", 123, 2001);
                song.DisplaySong();
            }
            else if (userInput == "3") 
            {
                playlist.ShowPlaylist();
            }
            else if (userInput == "4") 
            { 
                playlist.AddSongToPlaylist();
                playlist.ShowPlaylist();
            }
        }
    }
}
