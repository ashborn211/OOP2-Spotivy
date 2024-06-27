using System;
using System.Collections.Generic;
using OOP2_Spotivy;

public class Playlist
{
    private List<Song> songs;
    public string PlaylistName { get; private set; }
    private static List<Playlist> playlists = new List<Playlist>();
    public Playlist()
    {
        songs = new List<Song>();
    }
    public void SetPlaylistName(string name)
    {
        PlaylistName = name;
    }
    public void AddSong(Song song)
    {
        if (!songs.Contains(song))
        {
            songs.Add(song);
            Console.WriteLine($"Added {song.Title} to the playlist '{PlaylistName}'.");
        }
        else
        {
            Console.WriteLine($"The song {song.Title} is already in the playlist '{PlaylistName}'.");
        }
    }
    public void DisplayPlaylist()
    {
        Console.WriteLine($"\nPlaylist: {PlaylistName}");
        foreach (var song in songs)
        {
            Console.WriteLine(song);
        }
    }
    public static void DisplayAllPlaylists()
    {
        Console.WriteLine("\nAll Playlists:\n");
        List<string> printedPlaylists = new List<string>();
        foreach (var playlist in playlists)
        {
            if (!printedPlaylists.Contains(playlist.PlaylistName))
            {
                printedPlaylists.Add(playlist.PlaylistName);
                Console.WriteLine($"Playlist: {playlist.PlaylistName}");
                foreach (var song in playlist.songs)
                {
                    Console.WriteLine(song);
                }
                Console.WriteLine();
            }
        }
    }
    public static List<Playlist> GetPlaylists()
    {
        return playlists;
    }

    public static void AddPlaylist(Playlist playlist)
    {
        playlists.Add(playlist);
    }
    public static Playlist GetPlaylistByName(string name)
    {
        return playlists.Find(playlist => playlist.PlaylistName == name);
    }
    public void AddToPlaylist(SongList songList)
    {
        Console.WriteLine("\nEnter playlist name:");
        string name = Console.ReadLine();
        SetPlaylistName(name);
        Console.WriteLine($"Made playlist '{name}'.");
        Console.WriteLine("\nAdding songs to playlist...");
        songList.DisplayAllSongs();
        Console.WriteLine("\nEnter the ID of the song you want to add to the playlist (enter 0 to stop adding):");

        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int songId))
            {
                if (songId == 0)
                {
                    Console.WriteLine("\nStopped adding songs to playlist.");
                    break;
                }

                Song selectedSong = songList.GetSongById(songId);
                if (selectedSong != null)
                {
                    AddSong(selectedSong);
                }
                else
                {
                    Console.WriteLine("Song not found. Please enter a valid ID.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
        AddPlaylist(this);
    }
    public static void PlayPlaylist()
    {
        Console.WriteLine("\nEnter playlist name to play:");
        string playlistName = Console.ReadLine();

        Playlist playlist = GetPlaylistByName(playlistName);
        if (playlist != null)
        {
            Console.WriteLine($"\nPlaying playlist: {playlistName}\n");
            foreach (var song in playlist.songs)
            {
                Console.WriteLine($"Now playing: {song.Title} by {song.Artist}...");
                System.Threading.Thread.Sleep(10000);
                Console.WriteLine($"Finished: {song.Title}\n");
            }
        }
        else
        {
            Console.WriteLine($"Playlist '{playlistName}' not found.");
        }
    }
}
