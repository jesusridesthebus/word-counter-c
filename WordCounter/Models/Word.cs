using System.Collections.Generic;

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



  }
}