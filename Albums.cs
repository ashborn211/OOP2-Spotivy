using System;
using System.Collections.Generic;

namespace OOP2_Spotivy
{
    internal class Albums
    {
        internal class Album
        {
            public string Title { get; set; }
            public List<string> Artists { get; set; }
            public string Genre { get; set; }
            public List<string> Songs { get; set; }

            public Album(string title, List<string> artists, string genre, List<string> songs)
            {
                Title = title;
                Artists = artists;
                Genre = genre;
                Songs = songs;
            }
        }

        internal static class AlbumLibrary
        {
            private static List<Album> albums;

            static AlbumLibrary()
            {
                albums = new List<Album>();
                LoadAlbums();
            }

            private static void LoadAlbums()
            {
                albums.Add(new Album("A Night at the Opera", new List<string> { "Queen" }, "Rock", new List<string>
                {
                    "Bohemian Rhapsody"
                }));
                albums.Add(new Album("Hotel California", new List<string> { "Eagles" }, "Rock", new List<string>
                {
                    "Hotel California"
                }));
                albums.Add(new Album("Led Zeppelin IV", new List<string> { "Led Zeppelin" }, "Rock", new List<string>
                {
                    "Stairway to Heaven"
                }));
                albums.Add(new Album("Imagine", new List<string> { "John Lennon" }, "Pop", new List<string>
                {
                    "Imagine"
                }));
                albums.Add(new Album("Hey Jude", new List<string> { "The Beatles" }, "Pop", new List<string>
                {
                    "Hey Jude"
                }));
                albums.Add(new Album("Like a Rolling Stone", new List<string> { "Bob Dylan" }, "Folk Rock", new List<string>
                {
                    "Like a Rolling Stone"
                }));
                albums.Add(new Album("Let It Be", new List<string> { "The Beatles" }, "Pop Rock", new List<string>
                {
                    "Let It Be"
                }));
                albums.Add(new Album("Smells Like Teen Spirit", new List<string> { "Nirvana" }, "Grunge", new List<string>
                {
                    "Smells Like Teen Spirit"
                }));
                albums.Add(new Album("Billie Jean", new List<string> { "Michael Jackson" }, "Pop", new List<string>
                {
                    "Billie Jean"
                }));
                albums.Add(new Album("Yesterday", new List<string> { "The Beatles" }, "Pop", new List<string>
                {
                    "Yesterday"
                }));
                albums.Add(new Album("Born to Run", new List<string> { "Bruce Springsteen" }, "Rock", new List<string>
                {
                    "Born to Run"
                }));
                albums.Add(new Album("Hallelujah", new List<string> { "Jeff Buckley" }, "Alternative Rock", new List<string>
                {
                    "Hallelujah"
                }));
                albums.Add(new Album("Sweet Child o' Mine", new List<string> { "Guns N' Roses" }, "Hard Rock", new List<string>
                {
                    "Sweet Child o' Mine"
                }));
                albums.Add(new Album("Rolling in the Deep", new List<string> { "Adele" }, "Pop", new List<string>
                {
                    "Rolling in the Deep"
                }));
                albums.Add(new Album("Purple Rain", new List<string> { "Prince" }, "Rock", new List<string>
                {
                    "Purple Rain"
                }));
                albums.Add(new Album("Het is een nacht", new List<string> { "Guus Meeuwis" }, "Pop", new List<string>
                {
                    "Het is een nacht"
                }));
                albums.Add(new Album("Hey brother", new List<string> { "Avicii" }, "Electronic", new List<string>
                {
                    "Hey brother"
                }));
                albums.Add(new Album("Zij gelooft in mij", new List<string> { "Andre Hazes" }, "Dutch Pop", new List<string>
                {
                    "Zij gelooft in mij"
                }));
            }

            public static List<Album> GetAllAlbums()
            {
                return albums;
            }

            public static void ShowAllAlbums()
            {
                List<Album> albums = GetAllAlbums();
                Console.WriteLine("All Albums:");
                foreach (Album album in albums)
                {
                    Console.WriteLine($"Title: {album.Title}");
                    Console.WriteLine($"Artists: {string.Join(", ", album.Artists)}");
                    Console.WriteLine($"Genre: {album.Genre}");
                    Console.WriteLine("Songs:");
                    foreach (string song in album.Songs)
                    {
                        Console.WriteLine($"- Title: {song}");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}