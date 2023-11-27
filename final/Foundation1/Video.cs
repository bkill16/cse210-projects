public class Video {
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void Display()
    {
        Console.WriteLine($"{_title} by {_author} - {_length} seconds");
        Console.WriteLine($"Number of Comments: {_comments.Count()}");

        foreach (var comment in _comments)
        {
            comment.DisplayComment();

        }

        Console.WriteLine();
    }
}