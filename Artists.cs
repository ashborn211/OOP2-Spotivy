using System;
using System.Collections.Generic;

internal class ArtistLibrary
{
    public class Artists
    {
        public string Name { get; set; }
        public string Genre { get; set; }

        public Artists(string name, string genre)
        {
            Name = name;
            Genre = genre;
        }
    }

    private static List<Artists> artists;

    static ArtistLibrary()
    {
        artists = new List<Artists>();
        LoadArtists();
    }

    private static void LoadArtists()
    {
        artists.Add(new Artists("Queen", "Rock"));
        artists.Add(new Artists("Eagles", "Rock"));
        artists.Add(new Artists("Led Zeppelin", "Rock"));
        artists.Add(new Artists("John Lennon", "Pop"));
        artists.Add(new Artists("The Beatles", "Pop"));
        artists.Add(new Artists("Bob Dylan", "Folk Rock"));
        artists.Add(new Artists("Nirvana", "Grunge"));
        artists.Add(new Artists("Michael Jackson", "Pop"));
        artists.Add(new Artists("Bruce Springsteen", "Rock"));
        artists.Add(new Artists("Jeff Buckley", "Alternative Rock"));
        artists.Add(new Artists("Guns N' Roses", "Hard Rock"));
        artists.Add(new Artists("Adele", "Pop"));
        artists.Add(new Artists("Prince", "Rock"));
        artists.Add(new Artists("Guus Meeuwis", "Pop"));
        artists.Add(new Artists("Avicii", "Electronic"));
        artists.Add(new Artists("Andre Hazes", "Dutch Pop"));
    }

    public static void ShowAllArtists()
    {
        Console.WriteLine("All Artists:");
        foreach (Artists artist in artists)
        {
            Console.WriteLine($"Name: {artist.Name}, Genre: {artist.Genre}");
        }
    }
}