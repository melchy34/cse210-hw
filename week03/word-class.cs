public class Word
{
    public string Text { get; private set; }
    public string DisplayText { get; private set; }
    public bool IsHidden { get; private set; }

    public Word(string text)
    {
        Text = text;
        DisplayText = text;
        IsHidden = false;
    }

    public void Hide()
    {
        if (!IsHidden)
        {
            DisplayText = new string('_', Text.Length);
            IsHidden = true;
        }
    }

    public void Unhide()
    {
        DisplayText = Text;
        IsHidden = false;
    }
}
