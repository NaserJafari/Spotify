using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Spotify
{
    internal class User
    {
        public string name; //field voor de naam van een user
        public string password; //field voor de wachtwoord van een user
        public int userId; //field voor de userId van een user
        public List<Playlist> playlist; //een instantie van de Playlist klasse in een list
        public Artist artist; //een instantie van de Artist klasse

        //deze constructor initialiseert de fields en de objecten zoals van de Playlist klasse en van de Artist klasse
        public User() 
        {
            this.name = name;
            this.password = password;
            //hier maak ik nieuwe objecten van de Arist klasse en de Playlist klasse
            artist = new Artist("dj");
            playlist = new List<Playlist>();
        }

        //deze functie moet de inhoud van de playlist klasse displayen onder de ingelogde user die de playlist heeft aangemaakt
        public void DisplayUserPLaylist()
        {
            foreach (var item in playlist)  //een foreach om door de playlist heen te gaan en de inhoud daarvan de loggen
            {
                Console.WriteLine(item);
            }
        }

        //deze functie simuleert het inloggen
        public void LoginUser()
        {
            //hier vraagt om username en wachtwoord
            Console.WriteLine("Login in als gebruiker");
            string username = Console.ReadLine();
            
            Console.WriteLine();
            string password = Console.ReadLine();

            //hier kijkt ie of de username bij de password hoort, zoja, krijg je een tekst met je bent ingelogd anders, de gebruiker bestaat niet
            if (username == "user" &&  password == "password")
            {
                Console.WriteLine("Je bent ingelogd");
            }
            else
            {
                Console.WriteLine("De gebruiker bestaat niet");
            }

        }

        //deze functie moet de ingelogde user laten zien, bijvoorbeeld zijn vrienden of zijn playlists
        public void ShowLoginUser()
        {

        }

        //met deze methode moet ik vrienden kunnen maken met andere users
        public void makeFriend()
        {

        }
    }
}
