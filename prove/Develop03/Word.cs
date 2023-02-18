public class Word
{
    private string _word;
    
    private bool _hidden;

    public Word (string word)
    {
        _word = word;
        _hidden = true;
    }
    public void Hide()
    {
        char[] letters = _word.ToCharArray();
        for(int i = 0; i <_word.Length; i++)
        {
            letters[i] = '_';
        }
        _word = new string (letters);
        _hidden = false;
    }
    public string GetWord()
    {
        return _word;

    }
    public bool GetHidden()
    {
        return _hidden;

    }

    public bool ShowWord()
    { 
        if (_hidden)
        {
            return true;
        }
        else
        {
            return false; 
        }
    }
    
}