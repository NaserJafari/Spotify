namespace Spotify
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to Spotify!");
            Song song = new Song("title", "genre", 123, 2001);
            Client client = new Client();
            client.CheckUserInput();
        }
    }
}