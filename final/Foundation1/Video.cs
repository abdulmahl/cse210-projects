using static System.Console;

public class Video
{
    public string _title;
    public string _author;
    public decimal _length;
    List<Comment> comments = new List<Comment>();

    public Video(string title, string author, decimal length)
    {
       this._title = title;
       this._author = author;
       this._length = length;
    }

    public void GetComment(string name, string text)
    {
        var comment = new Comment(name, text);
        this.comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return this.comments.Count;
    }

    public List<Comment> Comments
    {
        get { return this.comments; }
    }
}