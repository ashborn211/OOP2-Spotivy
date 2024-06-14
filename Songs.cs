using System;
using System.Collections.Generic;
using System.IO;

public class Song
{
    public string Title { get; set; }
    public string Artist { get; set; }
    public string Album { get; set; }

    public Song(int id, string title, string genre, string artist, string album, double duration)
    {
        Title = title;
        Artist = artist;
        Album = album;
    }
}

public class SongList
{
    private List<Song> songs;

    public SongList()
    {
        songs = new List<Song>();
        LoadSongs(); // Load hardcoded songs
    }

    private void LoadSongs()
    {
        // Hardcoded list of songs
        songs.Add(new Song(1, "Bohemian Rhapsody", "pop", "Queen", "A Night at the Opera", 5.9));
        songs.Add(new Song(2, "Hotel California", "pop", "Eagles", "Hotel California", 6.51));
        songs.Add(new Song(3, "Stairway to Heaven", "pop", "Led Zeppelin", "Led Zeppelin IV", 8.03));
        songs.Add(new Song(4, "Imagine", "pop", "John Lennon", "Imagine", 3.11));
        songs.Add(new Song(5, "Hey Jude", "pop", "The Beatles", "Hey Jude", 3.93));
        songs.Add(new Song(6, "Like a Rolling Stone", "pop", "Bob Dylan", "Highway 61 Revisited", 3.4));
        songs.Add(new Song(7, "Let It Be", "pop", "The Beatles", "Let It Be", 4.05));
        songs.Add(new Song(8, "Smells Like Teen Spirit", "pop", "Nirvana", "Nevermind", 1.0));
        songs.Add(new Song(9, "Billie Jean", "pop", "Michael Jackson", "Thriller", 1.0));
        songs.Add(new Song(10, "Yesterday", "pop", "The Beatles", "Help!", 1.0));
        songs.Add(new Song(11, "Born to Run", "pop", "Bruce Springsteen", "Born to Run", 1.0));
        songs.Add(new Song(12, "Hallelujah", "pop", "Jeff Buckley", "Grace", 1.0));
        songs.Add(new Song(13, "Sweet Child o' Mine", "pop", "Guns N' Roses", "Appetite for Destruction", 1.0));
        songs.Add(new Song(14, "Rolling in the Deep", "pop", "Adele", "21", 1.0));
        songs.Add(new Song(15, "Purple Rain", "pop", "Prince", "Purple Rain", 1.0));
        songs.Add(new Song(16, "Het is een nacht", "pop", "Guus Meeuwis", "Verbazing", 1.0));
        songs.Add(new Song(17, "Hey brother", "pop", "Avicii", "True", 1.0));
        songs.Add(new Song(18, "Zij gelooft in mij", "pop", "Andre Hazes", "De Hazes 100", 1.0));
    }

    public List<Song> GetAllSongs()
    {
        return songs;
    }
}


public class ShowAllSongs
{
    private SongList songList;

    public ShowAllSongs(SongList songList)
    {
        this.songList = songList;
    }

    public void DisplayAllSongs()
    {
        List<Song> songs = songList.GetAllSongs();
        Console.WriteLine("All Songs:");
        foreach (Song song in songs)
        {
            Console.WriteLine($"Title: {song.Title}, Artist: {song.Artist}, Album: {song.Album}");
        }
    }
}

