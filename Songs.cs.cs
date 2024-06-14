using System;
using System.Collections.Generic;
using System.IO;

public class Song
{
    public string Title { get; set; }
    public string Artist { get; set; }
    public string Album { get; set; }

    public Song(string title, string artist, string album)
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
        songs.Add(new Song("Bohemian Rhapsody", "Queen", "A Night at the Opera"));
        songs.Add(new Song("Hotel California", "Eagles", "Hotel California"));
        songs.Add(new Song("Stairway to Heaven", "Led Zeppelin", "Led Zeppelin IV"));
        songs.Add(new Song("Imagine", "John Lennon", "Imagine"));
        songs.Add(new Song("Hey Jude", "The Beatles", "Hey Jude"));
        songs.Add(new Song("Like a Rolling Stone", "Bob Dylan", "Highway 61 Revisited"));
        songs.Add(new Song("Let It Be", "The Beatles", "Let It Be"));
        songs.Add(new Song("Smells Like Teen Spirit", "Nirvana", "Nevermind"));
        songs.Add(new Song("Billie Jean", "Michael Jackson", "Thriller"));
        songs.Add(new Song("Yesterday", "The Beatles", "Help!"));
        songs.Add(new Song("Born to Run", "Bruce Springsteen", "Born to Run"));
        songs.Add(new Song("Hallelujah", "Jeff Buckley", "Grace"));
        songs.Add(new Song("Sweet Child o' Mine", "Guns N' Roses", "Appetite for Destruction"));
        songs.Add(new Song("Rolling in the Deep", "Adele", "21"));
        songs.Add(new Song("Purple Rain", "Prince", "Purple Rain"));
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

