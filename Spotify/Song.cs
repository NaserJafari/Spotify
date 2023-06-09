using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class Song
    {
        public string title;
        public string genre;
        public int seconds;
        public int year;
        public Artist artist;

        public Song()
        {

        }

        public Song(string titleOfSong, string genreOfSong, int secondsOfSong, int yearOfSong, Artist songOfArtist)
        {
            title = titleOfSong;
            genre = genreOfSong;
            seconds = secondsOfSong;
            year = yearOfSong;
            artist = songOfArtist;
        }

        public void PlaySong()
        {
            Console.WriteLine("Welke song wil je afspelen?");
            /*string userInput = Console.ReadLine();

            while (userInput == "0") 
            {
                if (userInput == title)
                {
                    Console.WriteLine(title);
                }
                else 
                {
                    Console.WriteLine("Song titel bestaat niet");
                }
            }*/
            
            Console.WriteLine("Playing " + title + " , by " + artist);
        }

        public void DisplaySong()
        {
            Console.WriteLine("Playing: " + title + ", Genre: " + genre + ", Seconds: " + seconds + ", Year: " + year + " , Artist: " + artist);
        }

        public override string ToString() 
        { 
            return "Title: " + title + ", Genre:" + genre + ", Seconds: " + seconds + ", Year: " + year + " , Artist: " + artist;
        }
    }
}
