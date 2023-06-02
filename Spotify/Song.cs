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
        //public Artist artist;
        
        public Song()
        {

        }

        public Song(string titleOfSong, string genreOfSong, int secondsOfSong, int yearOfSong)
        {
            title = titleOfSong;
            genre = genreOfSong;
            seconds = secondsOfSong;
            year = yearOfSong;
            //hier moet nog de naam van de artiest komen
        }

        public void PlaySong()
        {
            Console.WriteLine("Playing " + title);
        }

        public void DisplaySong()
        {
            Console.WriteLine("Playing: " + title + ", Genre: " + genre + ", Seconds: " + seconds + ", Year: " + year);
        }

        public override string ToString() 
        { 
            return "Title: " + title + ", Genre:" + genre + ", Seconds: " + seconds + ", Year: " + year;
        }
    }
}
