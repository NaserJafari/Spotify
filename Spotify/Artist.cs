using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class Artist
    {
        public string name; //field name voor de Artist name

        //een constructor met parameter om nieuwe objecten te maken van de Artist klasse 
        public Artist(string nameOfArtist)
        {
            name = nameOfArtist;
        }


        //hier override ik de field van de Artist klasse en zet ik ze om naar een string
        public override string ToString()
        { 
            return name;
        }
    }
}
