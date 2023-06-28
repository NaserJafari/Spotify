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
        public string name;
        public string password;
        public int userId;
        public List<Playlist> playlist;
        public Artist artist;

        public User() 
        {
            this.name = name;
            this.password = password;
            artist = new Artist("dj");
            playlist = new List<Playlist>();
        }

        public void DisplayUserPLaylist()
        {
            foreach (var item in playlist)
            {
                Console.WriteLine(item);
            }
        }

        public void LoginUser()
        {
            Console.WriteLine("Login in als gebruiker");
            string username = Console.ReadLine();
            
            Console.WriteLine();
            string password = Console.ReadLine();

            if (username == "user" &&  password == "password")
            {
                Console.WriteLine("Je bent ingelogd");
            }
            else
            {
                Console.WriteLine("De gebruiker bestaat niet");
            }

        }

        public void ShowLoginUser()
        {

        }

        //met deze methode moet/mag ik vrienden kunnen maken
        public void makeFriend()
        {

        }
    }
}
