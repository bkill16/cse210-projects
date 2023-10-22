public class Reference
{
    private string _book;
    private int _chapter;
    private int _start;
    private int _end;
    private string _scriptReference;

    public Reference(string book, int chapter, int start, int end)
    {
        _book = book;
        _chapter = chapter;
        _start = start;
        _end = end;
    }

    public string FormatReference()
    {
        _scriptReference = $"{_book} {_chapter}:{_start}-{_end}";
        return _scriptReference;
    }
}