public class Book : Loanable
{
    private string _title;
    private string _isbn;
    private int _upc;

    public Book (string title, string isbn, int upc)
    {
        _title = title;
        _isbn = isbn;
        _upc = upc;
    }

    public override void Display()
    {
        ShowBookDetails();
    }

    public void ShowBookDetails()
    {
        Console.WriteLine();
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"ISBN: {_isbn}");
        Console.WriteLine($"UPC: {_upc}");
        Console.WriteLine($"Available: {_isCheckedIn}");
    }
}