using System.Collections.Generic;
using System;

namespace WordCounter
{
  public class RepeatCounter
  {
    public string Word {get; set;}
    public string Phrase {get; set;}
    public string[] SplitPhrase {get; set;}

    public RepeatCounter(string word, string phrase)
    {
      Word = word;
      Phrase = phrase;
      SplitPhrase = phrase.Split(" ");
    }

    public int Counter()
    {
      int totalCount = 0;
      foreach(var word in SplitPhrase)
      {
        string lowerWord = word.ToLower();
        if(lowerWord == Word)
        {
          totalCount++;
        }
      }
      return totalCount;
    }

    public string RemoveNonLetters(string word)
    {
      char[] wordArr = word.ToLower().ToCharArray();
      string alphaOnlyWord = "";
      foreach(char letter in wordArr)
      {
        if(Char.IsLetter(letter))
        {
        alphaOnlyWord += letter;
        }
      }
      return alphaOnlyWord.ToString();
    }

  }
}

