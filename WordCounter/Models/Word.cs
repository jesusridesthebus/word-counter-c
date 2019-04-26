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

    public void SetWord(string newWord)
    {
      _word = newWord;
    }

    public char[] MakeArray()
    {
      _word = _word.ToLower();
      char[] charArr = _word.ToCharArray();
      return charArr;
    }

  }
}