using System;
using System.Collections.Generic;
using System.IO;

public static class Albums
{
    public static List<string> GetAllAlbums()
    {
        return new List<string>
        {
            "A Night at the Opera",
            "Hotel California",
            "Led Zeppelin IV",
            "Imagine",
            "Hey Jude",
            "Highway 61 Revisited",
            "Let It Be",
            "Nevermind",
            "Thriller",
            "Help!",
            "Born to Run",
            "Grace",
            "Appetite for Destruction",
            "21",
            "Purple Rain"
            // Add more albums as needed
        };
    }

    public static void ShowAllAlbums()
    {
        List<string> albums = GetAllAlbums();
        Console.WriteLine("All Albums:");
        foreach (string album in albums)
        {
            Console.WriteLine(album);
        }
    }
}
