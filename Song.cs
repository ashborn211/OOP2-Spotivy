using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace OOP2_Spotivy
{
    public class Song
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public int SongDuration { get; set; }
        public int Id { get; set; }
        public string Genre { get; set; }

        public Song(int id, string title, string genre, string artist, string album, int songduration)
        {
            Title = title;
            Artist = artist;
            Album = album;
            SongDuration = songduration;
            Id = id;
            Genre = genre;
        }
        public static void PlaySong(SongList songList)
        {
            Console.WriteLine("\nWhich song do you want to play?");
            Console.WriteLine("Enter the ID of the desired song:");
            if (int.TryParse(Console.ReadLine(), out int songId))
            {
                Song selectedSong = songList.GetSongById(songId);
                if (selectedSong != null)
                {
                    Console.WriteLine($"{selectedSong.Title} by {selectedSong.Artist} is now playing...");
                }
                else
                {
                    Console.WriteLine("Song not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid ID.");
            }
        }
        public override string ToString()
        {
            return $"{Title} - {Artist} ({Album})";
        }
    }
}