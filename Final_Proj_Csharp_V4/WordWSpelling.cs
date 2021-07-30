using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Proj_Csharp_V4
{
    //The word spelling class job is to translate the words in the text files into objects in the
    //software so that it will be more convenient to work with.
    class WordWSpelling : Word
    {
        public string Worng1; //worng 1 for spelling practice
        public string Worng2;//worng 2 for spelling practice
        public string Worng3;//worng 3 for spelling practice


        public WordWSpelling(string id,string theWord,string sound,string worng1, string worng2, string worng3) : base(theWord,sound,id)
        {
            Worng1 = worng1;
            Worng2 = worng2;
            Worng3 = worng3;
        }

        public string Worng11 { get => Worng1; set => Worng1 = value; }
        public string Worng21 { get => Worng2; set => Worng2 = value; }
        public string Worng31 { get => Worng3; set => Worng3 = value; }


        
    }
}
