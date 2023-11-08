using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour
{
    public List<Word> words;

    public WordSpawner wordSpawner;
    private bool hasActiveWord;
    private Word activeWord;


    private void Start()
    {
        words = new List<Word>();
    }

    public void AddWord()
    {
        Word word = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
        Debug.Log(word.word);
        words.Add(word);
    }

    public void TypeLetter(char letter)
    {
        if (hasActiveWord)
        {
            if (activeWord.GetNextLetter() == letter)
            {
                activeWord.TypeLetter();
            }
        }
        else
        {
            foreach(Word w in words)
            {
                if (w.GetNextLetter() == letter)
                {
                    activeWord = w;
                    hasActiveWord = true;
                    activeWord.TypeLetter();
                    break;
                }
            }
        }
        if (hasActiveWord && activeWord.WordIsComplete())
        {
            hasActiveWord = false;
            words.Remove(activeWord);
        }
    }
}
