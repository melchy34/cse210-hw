public class Reference
{
    public string Book { get; }
    public int StartChapter { get; }
    public int StartVerse { get; }
    public int? EndVerse { get; }

    // Constructor for a single verse (e.g., "John 3:16")
    public Reference(string book, int chapter, int verse)
    {
        Book = book;
        StartChapter = chapter;
        StartVerse = verse;
        EndVerse = null;
    }

    // Constructor for a verse range (e.g., "Proverbs 3:5-6")
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        Book = book;
        StartChapter = chapter;
        StartVerse = startVerse;
        EndVerse = endVerse;
    }

    public string GetDisplayText()
    {
        if (EndVerse.HasValue)
        {
            return $"{Book} {StartChapter}:{StartVerse}-{EndVerse.Value}";
        }
        return $"{Book} {StartChapter}:{StartVerse}";
    }
}
