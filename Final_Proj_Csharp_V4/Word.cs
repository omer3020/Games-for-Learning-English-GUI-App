using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Proj_Csharp_V4
{
    //The word class takes care of the information about the words and from this class 2 more classes inherit
    class Word : IComparable
    {
        public string theWord;//the word itself
        public string sound;//path to sound file
        public string id;//uniqe id for the word
        public Word(string theWord, string sound,string id)
        {
            this.id = id;
            this.theWord = theWord;
            this.sound = sound;

        }
        public string Id { get => id; set => id = value; }
        public string TheWord { get => theWord; set => theWord = value; }
        public string Sound { get => sound; set => sound = value; }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
