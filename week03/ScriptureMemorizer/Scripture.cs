// Scripture.cs
using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private List<bool> _hiddenWords; // Keeps track of hidden words

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
        _hiddenWords = new List<bool>(new bool[_words.Count]); // All words start as visible
    }

    public string GetReference()
    {
        return _reference.GetReference(); // Use the Reference class's GetReference()
    }
    

    public string GetVisibleText()
    {
        return string.Join(" ", _words.Select((w, i) => _hiddenWords[i] ? "_____" : w.ToString()));
    }

    public void HideWords(int count)
    {
        Random random = new Random();
        int hidden = 0;

        while (hidden < count && _hiddenWords.Contains(false))
        {
            int index = random.Next(_words.Count);
            if (!_hiddenWords[index])
            {
                _hiddenWords[index] = true;
                hidden++;
            }
            if (!_hiddenWords.Contains(false))
            {
                break;
            }
        }
    }

    public void RevealOneWord()
    {
        Random random = new Random();
        List<int> hiddenIndexes = _hiddenWords
            .Select((isHidden, index) => new { isHidden, index })
            .Where(x => x.isHidden)
            .Select(x => x.index)
            .ToList();

        if (hiddenIndexes.Count > 0)
        {
            int randomIndex = hiddenIndexes[random.Next(hiddenIndexes.Count)];
            _hiddenWords[randomIndex] = false;
        }
    }

    public bool IsFullyHidden()
    {
        return _hiddenWords.All(hidden => hidden);
    }

    public void Reset()
    {
        _hiddenWords = new List<bool>(new bool[_words.Count]); // Reset all words to visible
    }
}










