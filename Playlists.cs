using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
public class Playlist
{
    private List<Song> songs;

    public Playlist()
    {
        songs = new List<Song>();
    }
    public void AddSong(Song song)
    {
        songs.Add(song);
        Console.WriteLine($"Added {song.Title} to the playlist.");
    }
    public void DisplayPlaylist()
    {
        Console.WriteLine("Playlist:");
        foreach (var song in songs)
        {
            Console.WriteLine(song);
        }
    }
}