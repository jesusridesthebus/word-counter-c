using System.Collections.Generic;

namespace WordCounter
{
  public class RepeatCounter
  {
    public string Word {get; set;}
    public string Phrase {get; set;}
    public string[] SplitPhrase {get; set;}
    // public char[] SplitWord {get; set;}

    // char[] letterArray = letterString.ToCharArray();
    // letterArray = Array.FindAll<char>(letterArray, (char => (char.IsLetter(c) || char.IsWhiteSpace(char))));
    // letterString = new string(letterArray);

    public RepeatCounter(string word, string phrase)
    {
      Word = word.ToLower();
      Phrase = phrase.ToLower();
      SplitPhrase = phrase.Split(" ");
      // SplitWord = phrase.Split("");
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

    public string RemoveNonLetters(string input)
    {
      StringBuilder sb = new StringBuilder();
      foreach(char c in input)
      {
        if(char.IsLetter(c))
        sb.Append(c);
      }
      return sb.ToString();
    }

  // public class StringBuilder
  // {
  //   // public string Word {get; set;}
  // }  
  }
}

