using System.Collections.Generic;
namespace OOP2_Spotivy
{
    internal class Songs
    {
        public class Song
        {
            public int ID { get; set; }
            public string Title { get; set; }
            public string Genre { get; set; }
            public double SongDuration { get; set; }
            public List<string> Artists { get; set; }
            public int ReleaseDate { get; set; }
            public string SongLyrics { get; set; }
            public double Duration { get; internal set; }
            public object Artist { get; internal set; }

            public Song(int id, string title, string genre, double songDuration, List<string> artists, int releaseDate, string songLyrics)
            {
                ID = id;
                Title = title;
                Genre = genre;
                SongDuration = songDuration;
                Artists = artists;
                ReleaseDate = releaseDate;
                SongLyrics = songLyrics;
            }
        }

        public class SongList
        {
            private List<Song> songs;

            public SongList()
            {
                songs = new List<Song>();
                LoadSongs();
            }

            private void LoadSongs()
            {
                songs.Add(new Song(1, "Bohemian Rhapsody", "pop", 5.9, new List<string> { "Queen" }, 1975, "..."));
                songs.Add(new Song(2, "Hotel California", "pop", 6.51, new List<string> { "Eagles" }, 1976, "..."));
                songs.Add(new Song(3, "Stairway to Heaven", "pop", 8.03, new List<string> { "Led Zeppelin" }, 1971, "..."));
                songs.Add(new Song(4, "Imagine", "pop", 3.11, new List<string> { "John Lennon" }, 1971, "..."));
                songs.Add(new Song(5, "Hey Jude", "pop", 3.93, new List<string> { "The Beatles" }, 1968, "..."));
                songs.Add(new Song(6, "Like a Rolling Stone", "pop", 3.4, new List<string> { "Bob Dylan" }, 1965, "..."));
                songs.Add(new Song(7, "Let It Be", "pop", 4.05, new List<string> { "The Beatles" }, 1970, "..."));
                songs.Add(new Song(8, "Smells Like Teen Spirit", "pop", 1.0, new List<string> { "Nirvana" }, 1991, "..."));
                songs.Add(new Song(9, "Billie Jean", "pop", 1.0, new List<string> { "Michael Jackson" }, 1982, "..."));
                songs.Add(new Song(10, "Yesterday", "pop", 1.0, new List<string> { "The Beatles" }, 1965, "..."));
                songs.Add(new Song(11, "Born to Run", "pop", 1.0, new List<string> { "Bruce Springsteen" }, 1975, "..."));
                songs.Add(new Song(12, "Hallelujah", "pop", 1.0, new List<string> { "Jeff Buckley" }, 1994, "..."));
                songs.Add(new Song(13, "Sweet Child o' Mine", "pop", 1.0, new List<string> { "Guns N' Roses" }, 1987, "..."));
                songs.Add(new Song(14, "Rolling in the Deep", "pop", 1.0, new List<string> { "Adele" }, 2010, "..."));
                songs.Add(new Song(15, "Purple Rain", "pop", 1.0, new List<string> { "Prince" }, 1984, "..."));
                songs.Add(new Song(16, "Het is een nacht", "pop", 1.0, new List<string> { "Guus Meeuwis" }, 1995, "..."));
                songs.Add(new Song(17, "Hey brother", "pop", 1.0, new List<string> { "Avicii" }, 2013, "..."));
                songs.Add(new Song(18, "Zij gelooft in mij", "pop", 1.0, new List<string> { "Andre Hazes" }, 1998, "..."));
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
                    Console.WriteLine($"ID: {song.ID}, Title: {song.Title}, Genre: {song.Genre}, Duration: {song.SongDuration}, Release Date: {song.ReleaseDate}, Lyrics: {song.SongLyrics}");
                    Console.WriteLine($"Artists: {string.Join(", ", song.Artists)}");
                }
            }
        }
    }
}