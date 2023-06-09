using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class Artist
    {
        public string name;

        public Artist(string nameOfArtist)
        {
            name = nameOfArtist;
        }

        public override string ToString()
        { 
            return name;
        }
    }
}
