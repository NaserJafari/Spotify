namespace Spotify
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to Spotify!");
            Artist artist = new Artist("dj");
            Song song = new Song("appelsap", "a-pop", 534, 1999, artist);
            Playlist playlist = new Playlist("titel", "genre", 321, 2000, artist);
            playlist.MakeNewPlaylist();

           /* song.PlaySong();
            Client client = new Client();
            client.CheckUserInput();
            Album album = new Album();
            album.ShowAlbum();*/
        }
    }
}