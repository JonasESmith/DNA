using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNA
{
  class Vocab
  {
    // vocab objects store the phrasein, phraseout, and the path to the destination needed. 
    string phraseIn;
    string phraseOut;
    string path;
    string tag;

    public Vocab()
    {
      phraseIn = "";
      PhraseOut = "";
      path = "";
      tag = "";
    }

    public Vocab(string PhraseIN, string PhraseOUT, string pathIn, string tagIn)
    {
      phraseIn = PhraseIN;
      PhraseOut = PhraseOUT;
      path = pathIn;
      tag = tagIn;
    }

    public string PhraseIn
    {
      get
      {
        return phraseIn;
      }
      set
      {
        phraseIn = value;
      }
    }

    public string PhraseOut
    {
      get
      {
        return phraseOut;
      }
      set
      {
        phraseOut = value;
      }
    }

    public string URL
    {
      get
      {
        return path;
      }
      set
      {
        path = value;
      }
    }

    public string Tag
    {
      get
      {
        return tag;
      }
      set
      {
        tag = value;
      }
    }

  }
}
