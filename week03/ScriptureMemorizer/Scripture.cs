using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        // Split on spaces; remove empty entries
        _words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                     .Select(w => new Word(w))
                     .ToList();
    }

    // Hide a number of random **visible** words (improved behavior)
    public void HideRandomWords(int numberToHide)
    {
        for (int i = 0; i < numberToHide; i++)
        {
            var visible = _words.Where(w => !w.IsHidden()).ToList();
            if (visible.Count == 0) break;

            int index = _random.Next(visible.Count);
            visible[index].Hide();
        }
    }

    public string GetDisplayText()
    {
        string joined = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{_reference.GetDisplayText()} - {joined}";
    }

    public bool AllWordsHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}