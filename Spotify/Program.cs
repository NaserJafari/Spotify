namespace Spotify
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to Spotify!");
            Song song = new("Titel song", "Genre song", 123, 2001);
            song.PlaySong();
            song.DisplaySong();
        }
    }
}