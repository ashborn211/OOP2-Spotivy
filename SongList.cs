using static OOP2_Spotivy.Song;

namespace OOP2_Spotivy
{
    public class SongList
    {
        private List<Song> songs;

        public SongList()
        {
            songs = new List<Song>();
            LoadSongs();
        }

        public void LoadSongs()
        {
            // Hardcoded list of songs
            songs.Add(new Song(1, "Bohemian Rhapsody", "Rock", "Queen", "A Night at the Opera", 354));
            songs.Add(new Song(2, "Hotel California", "Rock", "Eagles", "Hotel California", 391));
            songs.Add(new Song(3, "Stairway to Heaven", "Rock", "Led Zeppelin", "Led Zeppelin IV", 482));
            songs.Add(new Song(4, "Imagine", "Rock", "John Lennon", "Imagine", 187));
            songs.Add(new Song(5, "Hey Jude", "Rock", "The Beatles", "Hey Jude", 238));
            songs.Add(new Song(6, "Like a Rolling Stone", "Rock", "Bob Dylan", "Highway 61 Revisited", 369));
            songs.Add(new Song(7, "Let It Be", "Rock", "The Beatles", "Let It Be", 243));
            songs.Add(new Song(8, "Smells Like Teen Spirit", "Grunge", "Nirvana", "Nevermind", 301));
            songs.Add(new Song(9, "Billie Jean", "Pop", "Michael Jackson", "Thriller", 293));
            songs.Add(new Song(10, "Yesterday", "Pop", "The Beatles", "Help!", 125));
            songs.Add(new Song(11, "Born to Run", "Rock", "Bruce Springsteen", "Born to Run", 269));
            songs.Add(new Song(12, "Hallelujah", "Rock", "Jeff Buckley", "Grace", 217));
            songs.Add(new Song(13, "Sweet Child o' Mine", "Hard Rock", "Guns N' Roses", "Appetite for Destruction", 356));
            songs.Add(new Song(14, "Rolling in the Deep", "Pop", "Adele", "21", 228));
            songs.Add(new Song(15, "Purple Rain", "Rock", "Prince", "Purple Rain", 520));
            songs.Add(new Song(16, "Het is een nacht", "Nederpop", "Guus Meeuwis", "Verbazing", 225));
            songs.Add(new Song(17, "Hey Brother", "Country", "Avicii", "True", 255));
            songs.Add(new Song(18, "Zij gelooft in mij", "Nederpop", "Andre Hazes", "De Hazes 100", 229));
        }

        public void DisplayAllSongs()
        {
            List<Song> songs = GetAllSongs();
            Console.WriteLine("\nAll Songs:");
            foreach (Song song in songs)
            {
                Console.WriteLine($"Title: {song.Title}, Artist: {song.Artist}, Album: {song.Album}, Duration: {song.SongDuration}, Genre: {song.Genre}, ID: {song.Id} ");
            }
        }
        public List<Song> GetAllSongs()
        {
            return songs;
        }
        public Song GetSongById(int id)
        {
            return songs.Find(song => song.Id == id);
        }
    }
}