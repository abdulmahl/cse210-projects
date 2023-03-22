using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        List<Video> video = CreateList();
        Clear();

        WriteLine("Abstraction with YouTube Videos:");

        Display(video);
    }

    public static void Display(List<Video> videos)
    {
        foreach (Video video in videos)
        {
            WriteLine($"Author: {video._author}");
            WriteLine($"Title: {video._title}");
            WriteLine($"Length: {video._length} Seconds\n");
            WriteLine($"{video.GetCommentCount()} Comments\n");
            foreach (var comment in video.Comments)
            {
                WriteLine($"{comment._name}");
                WriteLine($"{comment._comment}\n");
            }
        }
    }

    public static List<Video> CreateList()
    {
        Video youtube1 = new Video("C# abstract classes 👻", "Bro Code", 155);
        Video youtue2 = new Video("", "", 0);
        Video youtue3 = new Video("", "", 0);
        Video youtue4 = new Video("", "", 0);

        List<Video> video = new List<Video>() { youtube1 };

        youtube1.GetComment("@leonvieira3877", "Quick and simple, nice refresher/introduction to the concept. Much appreciated.");
        youtube1.GetComment("@vandermunnik", "Thanks man! Simple and straight to the point! Your explanation actually clicked in my brain!!");
        WriteLine();
        return video;
    }
}

// AIzaSyDVdFMtg7dOOFVXog5FzQSMgQd47n2HmPg