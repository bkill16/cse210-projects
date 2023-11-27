public class Comment {
    private string _commenter;
    private string _content;

    public Comment(string commenter, string content)
    {
        _commenter = commenter;
        _content = content;
    }

    public void DisplayComment()
    {
        Console.WriteLine($" {_commenter} - {_content}");
    }
}