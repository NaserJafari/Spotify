using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class Song
    {
        public string title; //field voor de naam van een song
        public string genre; //field voor de genre van een song
        public int seconds; //field voor hoelang een song moet zijn
        public int year; //field voor wanneer de song uitkwam
        public Artist artist; //een instantie van de Artist klasse

        //deze constructor maakt nieuwe objecten zonder parameters
        public Song()
        {

        }

        //deze constructor maakt nieuwe objecten met parameters van de fields in het begin van de song klasse
        public Song(string titleOfSong, string genreOfSong, int secondsOfSong, int yearOfSong, Artist songOfArtist)
        {
            //hier initialiseer ik de waardes 
            title = titleOfSong; 
            genre = genreOfSong;
            seconds = secondsOfSong;
            year = yearOfSong;
            artist = songOfArtist;
        }

        //deze functie simuleert het afspelen van een song
        public void PlaySong()
        {
            //hier print hij de gewoon welke song hij afspeelt met fields hierboven
            Console.WriteLine("Playing: " + title + ", Genre: " + genre + ", Seconds: " + seconds + ", Year: " + year + " , Artist: " + artist);

            //hier wacht ie 5 seconden en gaat hij weer verder om het afspelen van een song te simuleren
            Thread.Sleep(5000);

            //hier print hij welke song hij heeft afgespeeld
            Console.WriteLine("Played: " + title + ", Genre: " + genre + ", Seconds: " + seconds + ", Year: " + year + " , Artist: " + artist);
        }

        //een functie die de song data moet gaan displayen, in dit geval de titel, genre, seconds, year en artist
        public void DisplaySong()
        {
            Console.WriteLine("Playing: " + title + ", Genre: " + genre + ", Seconds: " + seconds + ", Year: " + year + " , Artist: " + artist);
        }


        //hier override ik de fields van de song klasse en zet ik ze om naar een string
        public override string ToString() 
        { 
            return "Title: " + title + ", Genre:" + genre + ", Seconds: " + seconds + ", Year: " + year + " , Artist: " + artist;
        }
    }
}
