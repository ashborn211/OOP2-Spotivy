using System;
using System.Collections.Generic;
using System.IO;

using System;
using System.Collections.Generic;

public class Album
{
    public string Title { get; set; }
    public List<string> Artists { get; set; }
    public int NumberOfSongs { get; set; }
    public List<Song> Songs { get; set; }

    public Album(string title, List<string> artists, int numberOfSongs, List<Song> songs)
    {
        Title = title;
        Artists = artists;
        NumberOfSongs = numberOfSongs;
        Songs = songs;
    }
}

public static class Albums
{
    public static List<Album> GetAllAlbums()
    {
        List<Album> albums = new List<Album>
        {
            new Album("A Night at the Opera", new List<string>{"Queen"}, 1, new List<Song>
            {
                new Song(1, "Bohemian Rhapsody", "pop", "Queen", "A Night at the Opera", 5.9)
            }),
            new Album("Hotel California", new List<string>{"Eagles"}, 1, new List<Song>
            {
                new Song(2, "Hotel California", "pop", "Eagles", "Hotel California", 6.51)
            }),
            new Album("Led Zeppelin IV", new List<string>{"Led Zeppelin"}, 1, new List<Song>
            {
                new Song(3, "Stairway to Heaven", "pop", "Led Zeppelin", "Led Zeppelin IV", 8.03)
            }),
            new Album("Imagine", new List<string>{"John Lennon"}, 1, new List<Song>
            {
                new Song(4, "Imagine", "pop", "John Lennon", "Imagine", 3.11)
            }),
            new Album("Hey Jude", new List<string>{"The Beatles"}, 1, new List<Song>
            {
                new Song(5, "Hey Jude", "pop", "The Beatles", "Hey Jude", 3.93)
            }),
            new Album("Highway 61 Revisited", new List<string>{"Bob Dylan"}, 1, new List<Song>
            {
                new Song(6, "Like a Rolling Stone", "pop", "Bob Dylan", "Highway 61 Revisited", 3.4)
            }),
            new Album("Let It Be", new List<string>{"The Beatles"}, 1, new List<Song>
            {
                new Song(7, "Let It Be", "pop", "The Beatles", "Let It Be", 4.05)
            }),
            new Album("Nevermind", new List<string>{"Nirvana"}, 1, new List<Song>
            {
                new Song(8, "Smells Like Teen Spirit", "pop", "Nirvana", "Nevermind", 1.0)
            }),
            new Album("Thriller", new List<string>{"Michael Jackson"}, 1, new List<Song>
            {
                new Song(9, "Billie Jean", "pop", "Michael Jackson", "Thriller", 1.0)
            }),
            new Album("Help!", new List<string>{"The Beatles"}, 1, new List<Song>
            {
                new Song(10, "Yesterday", "pop", "The Beatles", "Help!", 1.0)
            }),
            new Album("Born to Run", new List<string>{"Bruce Springsteen"}, 1, new List<Song>
            {
                new Song(11, "Born to Run", "pop", "Bruce Springsteen", "Born to Run", 1.0)
            }),
            new Album("Grace", new List<string>{"Jeff Buckley"}, 1, new List<Song>
            {
                new Song(12, "Hallelujah", "pop", "Jeff Buckley", "Grace", 1.0)
            }),
            new Album("Appetite for Destruction", new List<string>{"Guns N' Roses"}, 1, new List<Song>
            {
                new Song(13, "Sweet Child o' Mine", "pop", "Guns N' Roses", "Appetite for Destruction", 1.0)
            }),
            new Album("21", new List<string>{"Adele"}, 1, new List<Song>
            {
                new Song(14, "Rolling in the Deep", "pop", "Adele", "21", 1.0)
            }),
            new Album("Purple Rain", new List<string>{"Prince"}, 1, new List<Song>
            {
                new Song(15, "Purple Rain", "pop", "Prince", "Purple Rain", 1.0)
            }),
            new Album("Verbazing", new List<string>{"Guus Meeuwis"}, 1, new List<Song>
            {
                new Song(16, "Het is een nacht", "pop", "Guus Meeuwis", "Verbazing", 1.0)
            }),
            new Album("True", new List<string>{"Avicii"}, 1, new List<Song>
            {
                new Song(17, "Hey brother", "pop", "Avicii", "True", 1.0)
            }),
            new Album("De Hazes 100", new List<string>{"Andre Hazes"}, 1, new List<Song>
            {
                new Song(18, "Zij gelooft in mij", "pop", "Andre Hazes", "De Hazes 100", 1.0)
            }),
        };
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
                Console.WriteLine($"- Title: {song.Title}, Artist: {song.Artist}");
            }
            Console.WriteLine();
        }
    }
}
