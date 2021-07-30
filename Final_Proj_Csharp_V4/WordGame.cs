using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Proj_Csharp_V4
{
    //The wordgame class job is to translate the words in the text files into objects in
    //the software so that it will be more convenient to work with.
    class WordGame : Word

    {
        public string theImage; //path to image
        public string firstLetter;//the first lettter of the word
        public string additionalLetter1;//additional letter of the word
        public string additionalLetter2;//additional letter of the word

        public string TheImage { get => theImage; set => theImage = value; }
        public string FirstLetter { get => firstLetter; set => firstLetter = value; }
        public string AdditionalLetter1 { get => additionalLetter1; set => additionalLetter1 = value; }
        public string AdditionalLetter2 { get => additionalLetter2; set => additionalLetter2 = value; }

        public WordGame(string id, string theWord, string sound, string theImage, string firstLetter, string additionalLetter1, string additionalLetter2) : base(theWord, sound, id)
        {
            TheImage = theImage;
            FirstLetter = firstLetter;
            AdditionalLetter1 = additionalLetter1;
            AdditionalLetter2 = additionalLetter2;
        }


     


    }
}
