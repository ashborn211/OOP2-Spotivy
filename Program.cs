using System;
using OOP2_Spotivy;

internal class Program
{
    private static void Main(string[] args)
    {
        bool exit = false;
        SongList songList = new SongList();
         
        while (!exit)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. View all songs");
            Console.WriteLine("2. View all albums");
            Console.WriteLine("3. View all artists");
            Console.WriteLine("4. Create a playlist");
            Console.WriteLine("5. View your playlists");
            Console.WriteLine("6. View friends");
            Console.WriteLine("7. Close Program");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    songList.DisplayAllSongs();
                    Song.PlaySong(songList);
                    break;
                case "2":
                    AlbumLibrary.ShowAllAlbums();
                    break;
                case "3":
                    // Implement view all artists
                    break;
                case "4":
                    Playlist newPlaylist = new Playlist();
                    newPlaylist.AddToPlaylist(songList);
                    Playlist.AddPlaylist(newPlaylist);
                    break;
                case "5":
                    Playlist.DisplayAllPlaylists();
                    Playlist.PlayPlaylist();
                    break;
                case "6":
                    Console.WriteLine("friends comin soon...");
                    break;
                case "7":
                    Console.WriteLine("Closing program...");
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
            Console.WriteLine();
        }
    }
}
