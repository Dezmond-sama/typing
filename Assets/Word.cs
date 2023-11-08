using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Word
{
    public string word;
    private int index = 0;
    private WordDisplay display;

    public Word(string _word, WordDisplay _display)
    {
        word = _word;
        display = _display;
        display.SetWord(word);
    }
    public char GetNextLetter()
    {
        return word[index];
    }
    public void TypeLetter()
    {
        index++;
        display.RemoveLetter();
    }
    public bool WordIsComplete()
    {
        if (index >= word.Length)
        {
            display.RemoveWord();
            return true;
        }
        return false;
    }
}
