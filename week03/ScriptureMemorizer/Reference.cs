// Reference.cs
class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;

    // Constructor for single-verse references
    public Reference(string b, int c, int v)
    {
        _book = b;
        _chapter = c;
        _verse = v;
    }

    // Constructor for multi-verse references
    public Reference(string b, int c, int startVerse, int endVerse)
    {
        _book = b;
        _chapter = c;
        _verse = startVerse; // Handling for multiple verses can be adjusted
    }

    // Getters
    public string GetBook()
    {
        return _book;
    }

    public int GetChapter()
    {
        return _chapter;
    }

    public int GetVerse()
    {
        return _verse;
    }

    // Setters
    public void SetBook(string book)
    {
        _book = book;
    }

    public void SetChapter(int chapter)
    {
        _chapter = chapter;
    }

    public void SetVerse(int verse)
    {
        _verse = verse;
    }

    public string GetReference()
    {
        return $"{GetBook()} {GetChapter()}:{GetVerse()}";
    }
}




