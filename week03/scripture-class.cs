using System;
using System.Collections.Generic;

public class Scripture
{
    public Reference Reference { get; private set; }
    private List<Word> Words { get; set; }

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = new List<Word>();

        // Split the text into words and create Word objects
        foreach (var wordText in text.Split(' '))
        {
            Words.Add(new Word(wordText));
        }
    }

    // Method to display the full scripture
    public void Display()
    {
        Console.Clear();
        Console.WriteLine(Reference.GetDisplayText());
        foreach (var word in Words)
        {
            Console.Write(word.DisplayText + " ");
        }
        Console.WriteLine();
    }

    // Method to hide a random word
    public void HideRandomWord(Random rand)
    {
        var visibleWords = Words.FindAll(w => !w.IsHidden);
        if (visibleWords.Count > 0)
        {
            var randomWord = visibleWords[rand.Next(visibleWords.Count)];
            randomWord.Hide();
        }
    }

    // Method to check if all words are hidden
    public bool AllWordsHidden()
    {
        return Words.TrueForAll(w => w.IsHidden);
    }
}
