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
            public int NumberOfSongs { get; set; }
            public List<Song> Songs { get; set; }

            public Album(string title, List<string> artists, List<Song> songs)
            {
                Title = title;
                Artists = artists;
                NumberOfSongs = songs.Count;
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
                albums.Add(new Album("A Night at the Opera", new List<string> { "Queen" }, new List<Song>
    {
        new Song(1, "Bohemian Rhapsody", "pop", 5.9, new List<string>{"Queen"}, 1975, "...")
    }));
                albums.Add(new Album("Hotel California", new List<string> { "Eagles" }, new List<Song>
    {
        new Song(2, "Hotel California", "pop", 6.51, new List<string>{"Eagles"}, 1976, "...")
    }));
                albums.Add(new Album("Led Zeppelin IV", new List<string> { "Led Zeppelin" }, new List<Song>
    {
        new Song(3, "Stairway to Heaven", "pop", 8.03, new List<string>{"Led Zeppelin"}, 1971, "...")
    }));
                albums.Add(new Album("Imagine", new List<string> { "John Lennon" }, new List<Song>
    {
        new Song(4, "Imagine", "pop", 3.11, new List<string>{"John Lennon"}, 1971, "...")
    }));
                albums.Add(new Album("Hey Jude", new List<string> { "The Beatles" }, new List<Song>
    {
        new Song(5, "Hey Jude", "pop", 3.93, new List<string>{"The Beatles"}, 1968, "...")
    }));
                albums.Add(new Album("Like a Rolling Stone", new List<string> { "Bob Dylan" }, new List<Song>
    {
        new Song(6, "Like a Rolling Stone", "pop", 3.4, new List<string>{"Bob Dylan"}, 1965, "...")
    }));
                albums.Add(new Album("Let It Be", new List<string> { "The Beatles" }, new List<Song>
    {
        new Song(7, "Let It Be", "pop", 4.05, new List<string>{"The Beatles"}, 1970, "...")
    }));
                albums.Add(new Album("Smells Like Teen Spirit", new List<string> { "Nirvana" }, new List<Song>
    {
        new Song(8, "Smells Like Teen Spirit", "pop", 1.0, new List<string>{"Nirvana"}, 1991, "...")
    }));
                albums.Add(new Album("Billie Jean", new List<string> { "Michael Jackson" }, new List<Song>
    {
        new Song(9, "Billie Jean", "pop", 1.0, new List<string>{"Michael Jackson"}, 1982, "...")
    }));
                albums.Add(new Album("Yesterday", new List<string> { "The Beatles" }, new List<Song>
    {
        new Song(10, "Yesterday", "pop", 1.0, new List<string>{"The Beatles"}, 1965, "...")
    }));
                albums.Add(new Album("Born to Run", new List<string> { "Bruce Springsteen" }, new List<Song>
    {
        new Song(11, "Born to Run", "pop", 1.0, new List<string>{"Bruce Springsteen"}, 1975, "...")
    }));
                albums.Add(new Album("Hallelujah", new List<string> { "Jeff Buckley" }, new List<Song>
    {
        new Song(12, "Hallelujah", "pop", 1.0, new List<string>{"Jeff Buckley"}, 1994, "...")
    }));
                albums.Add(new Album("Sweet Child o' Mine", new List<string> { "Guns N' Roses" }, new List<Song>
    {
        new Song(13, "Sweet Child o' Mine", "pop", 1.0, new List<string>{"Guns N' Roses"}, 1987, "...")
    }));
                albums.Add(new Album("Rolling in the Deep", new List<string> { "Adele" }, new List<Song>
    {
        new Song(14, "Rolling in the Deep", "pop", 1.0, new List<string>{"Adele"}, 2010, "...")
    }));
                albums.Add(new Album("Purple Rain", new List<string> { "Prince" }, new List<Song>
    {
        new Song(15, "Purple Rain", "pop", 1.0, new List<string>{"Prince"}, 1984, "...")
    }));
                albums.Add(new Album("Het is een nacht", new List<string> { "Guus Meeuwis" }, new List<Song>
    {
        new Song(16, "Het is een nacht", "pop", 1.0, new List<string>{"Guus Meeuwis"}, 1995, "...")
    }));
                albums.Add(new Album("Hey brother", new List<string> { "Avicii" }, new List<Song>
    {
        new Song(17, "Hey brother", "pop", 1.0, new List<string>{"Avicii"}, 2013, "...")
    }));
                albums.Add(new Album("Zij gelooft in mij", new List<string> { "Andre Hazes" }, new List<Song>
    {
        new Song(18, "Zij gelooft in mij", "pop", 1.0, new List<string>{"Andre Hazes"}, 1998, "...")
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
                    Console.WriteLine($"Number of Songs: {album.NumberOfSongs}");
                    Console.WriteLine("Songs:");
                    foreach (Song song in album.Songs)
                    {
                        Console.WriteLine($"- Title: {song.Title}");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
