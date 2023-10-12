public class Book
{
    private string _author;
    private string _name;
    private int _timesRead;
    private bool _available;

    public Book(string author, string name)
    {
        _author = author;
        _name = name;
        _timesRead = 0;
        _available = true;
    }

    public void Display()
    {
        Console.WriteLine($"\n{_author}");
        Console.WriteLine(_name);
        Console.WriteLine(_timesRead);
        Console.WriteLine($"{_available}\n");
    }

    public bool IsAvailable()
    {
        return _available;
    }

    public int TimesRead()
    {
        return _timesRead;
    }

    public void CheckOut()
    {
        _timesRead += 1;
        _available = false;
    }

    public void CheckIn()
    {
        _available = true;
    }

    public bool HasAuthor(string author)
    {
        return _author.Contains(author);
    }   
}