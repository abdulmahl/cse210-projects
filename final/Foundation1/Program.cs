using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        Clear();
        List<Video> videos = CreateList();

        Display(videos);
    }

    public static void Display(List<Video> videos)
    {
        int i = 0;
        foreach (Video video in videos)
        {
            i++;
            WriteLine($"({i})");
            WriteLine($"Author: {video._author}");
            WriteLine($"Title: {video._title}");
            WriteLine($"Length: {video._length} Seconds");
            WriteLine($"{video.GetCommentCount()} Comments\n");
            foreach (var comment in video.Comments)
            {
                Write($"{comment._name}, ");
                WriteLine($"{comment._comment}\n");
            }
            WriteLine("---------------------------------------------------------------------------");
            WriteLine();
        }
    }

    public static List<Video> CreateList()
    {
        Video youtube1 = new Video("C# abstract classes 👻", "Bro Code", 155);
        Video youtube2 = new Video("Do You Know Enough JavaScript To Learn React", "Web Dev Simplified", 382);
        Video youtube3 = new Video("STOP Learning These Programming Languages (for Beginners)", "y Sterkowitz", 324);
        Video youtube4 = new Video("Python's Map Function Explained..", "b001", 181);

        List<Video> videos = new List<Video>() { youtube1, youtube2, youtube3, youtube4 };

        youtube1.GetComment("@leonvieira3877", "Quick and simple, nice refresher/introduction to the concept. Much appreciated.");
        youtube1.GetComment("@vandermunnik", "Thanks man! Simple and straight to the point! Your explanation actually clicked in my brain!!");

        youtube2.GetComment("@JermaineMorgan", "I know console.log and THATS ALL I NEED");
        youtube2.GetComment("@adnanamin3666", "Man! I needed this so badly. Thanks for making a video on this topic. Appreciate the hard work. 🥰");

        youtube3.GetComment("@happyhippiehose7791", "I'm going to start with assembly language. It looks pretty simple.");
        youtube3.GetComment("@AndySterkowitz", "What programming language did you choose to be your first?");
        
        youtube4.GetComment("@codenerd7823", "Mark my words, this channel will be one of the most loved ones someday, because the content is so so awesome here.Even though I'm not a beginner, I'm glad this channel pops up in my recommendation");
        youtube4.GetComment("@znarutopvp9735", "cleared all my doubts without me even asking");
        youtube4.GetComment("@IntricateMoon", "omg so simple yet so clear. THANK YOU!! 🤩");
        WriteLine();
        return videos;
    }
}
