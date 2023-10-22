
using System.Text.RegularExpressions;

public class Word
{
    private string _hiddenWord;
    private bool _isHidden;

    public Word(string hiddenWord)
    {
        _hiddenWord = hiddenWord;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string DisplayHideWord()
    {
        if (_isHidden)
        {
            _hiddenWord = Regex.Replace(_hiddenWord, @"[a-zA-Z]", "_");
            return _hiddenWord;
        }
        else
        {
            return _hiddenWord;
        }
    }
}