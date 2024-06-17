using System;
using static OOP2_Spotivy.Albums;
using static OOP2_Spotivy.Songs;

namespace OOP2_Spotivy
{
    internal class Program
    {
        static void Main()
        {
            bool exit = false;
            SongList songList = new SongList();
            ShowAllSongs showAllSongs = new ShowAllSongs(songList);
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
                        showAllSongs.DisplayAllSongs();
                        break;
                    case "2":
                        AlbumLibrary.ShowAllAlbums();
                        break;
                    case "3":
                        // Implement view all artists
                        break;
                    case "4":
                        // Implement create a playlist
                        break;
                    case "5":
                        // Implement view your playlists
                        break;
                    case "6":
                        // Implement view friends
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
}
