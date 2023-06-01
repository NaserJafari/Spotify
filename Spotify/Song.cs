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
        
        public Song(string title, string genre, int seconds, int year)
        {
            this.title = title;
            this.genre = genre;
            this.seconds = seconds;
            this.year = year;
        }

        public void PlaySong()
        {
            Console.WriteLine("Playing " + title);
        }

        public void DisplaySong()
        {
            Console.WriteLine("Playing: " + title + ", Genre: " + genre + ", Seconds: " + seconds + ", Year: " + year);
        }
    }
}
