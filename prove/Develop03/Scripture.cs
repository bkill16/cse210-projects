using System.Diagnostics;
using System.IO.Compression;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;
using System.Xml.Schema;

public class Scripture
{
    private Reference _scriptReference;
    private string _scriptText;
    private List<Word> _wordsList;
    private List<int> _hiddenIndexes;

    public Scripture(string scriptText)
    {
        _scriptText = scriptText;
        _wordsList = new List<Word>();
        _hiddenIndexes = new List<int>();

        CreateList();
    }

    public void CreateList()
    {
        var words = _scriptText.Split(' ');
        foreach (var word in words)
        {
            _wordsList.Add(new Word(word));
        }
    }

    public void GetHiddenWord()
    {
        if ( _hiddenIndexes.Count() < _wordsList.Count())
        {

            var random = new Random();
            int indexHidden;
            
            do {indexHidden = random.Next(0, _wordsList.Count());}
            while (_hiddenIndexes.Contains(indexHidden));

            _wordsList[indexHidden].Hide();
            _hiddenIndexes.Add(indexHidden);
        }
    }
    
    public void SetReference(Reference reference)
    {
        _scriptReference = reference;
    }

    public void Display()
    {
        Console.WriteLine(_scriptReference.FormatReference());
        List<string> newWords = new List<string>();
        foreach (var word in _wordsList)
        {
            newWords.Add(word.DisplayHideWord());
        }

        string renderedText = string.Join(' ', newWords);
        Console.WriteLine(renderedText);
    }

    public bool IsCompletelyHidden()
    {
        foreach (var word in _wordsList)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}