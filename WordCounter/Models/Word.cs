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
        if(word == Word)
        {
          totalCount++;
        }
      }
      return totalCount;
    }

  }
}