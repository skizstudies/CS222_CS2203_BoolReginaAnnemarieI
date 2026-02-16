using System;

class Song
{
    public string title;
    public string artist;
    public double duration;

    public Song() : this("Unknown", "Unknown", 0) { }

    public Song(string title, string artist, double duration)
    {
        this.title = string.IsNullOrWhiteSpace(title) ? "Unknown" : title;
        this.artist = string.IsNullOrWhiteSpace(artist) ? "Unknown" : artist;
        this.duration = duration;
    }

    public Song(string title, string artist) : this(title, artist, 0) { }

    public void DisplaySong()
    {
        Console.WriteLine("{0,-20} {1,-15} {2,6:F2}", title, artist, duration);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Songs to add: ");
        int num = int.Parse(Console.ReadLine()!);

        Song[] playlist = new Song[num];

        for (int i = 0; i < num; i++)
        {
            Console.WriteLine("\nSong #" + (i + 1));

            Console.Write("Title: ");
            string t = Console.ReadLine()!;

            Console.Write("Artist: ");
            string a = Console.ReadLine()!;

            Console.Write("Duration (minutes): ");
            string minStr = Console.ReadLine()!;

            if (string.IsNullOrWhiteSpace(t) && string.IsNullOrWhiteSpace(a))
            {
                playlist[i] = new Song();
            }
            else if (!double.TryParse(minStr, out double mins))
            {
                playlist[i] = new Song(t, a);
            }
            else
            {
                playlist[i] = new Song(t, a, mins);
            }
        }

        Console.WriteLine("\n=== || MY PLAYLIST || ===");
        Console.WriteLine("{0,-20} {1,-15} {2,6}", "Title", "Artist", "Time");
        Console.WriteLine("----------------------------------------------");

        double totalDuration = 0;

        for (int i = 0; i < playlist.Length; i++)
        {
            playlist[i].DisplaySong();
            totalDuration += playlist[i].duration;
        }

        double averageDuration = num > 0 ? totalDuration / num : 0;

        Console.WriteLine("\nTotal Duration: {0:F2} mins", totalDuration);
        Console.WriteLine("Average Duration: {0:F2} mins", averageDuration);
    }
}