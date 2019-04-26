using System.Collections.Generic;

namespace WordCounter
{
  public class Word
  {
    private string _word;

    public Word(string word)
    {
      _word = word;
    }

    public string GetWord()
    {
      return _word;
    }

  }
}