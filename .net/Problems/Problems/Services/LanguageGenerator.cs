﻿namespace Problems.Services
{
    public class LanguageGenerator
    {
        // this is the code equivalent of having AIDS, rewrite it!
        private string[] _vowels = new string[]{"a", "e", "y", "u", "i", "o"};
        private string[] _consonants = new string[]{"q", "w", "r", "t", "p", "s", "d", "f", "g", "h",
        "j", "k", "l", "z", "x", "c", "v", "b", "n", "m"};

        private string[] _syllables = new string[]{ };
        private Dictionary<string, string> _inclinations = new Dictionary<string, string>()
        {
            {"I", ""},
            {"You", ""},
            {"He", ""},
            {"She", ""},
            {"It", ""},
            {"We", ""},
            {"They", ""}
        };

        // the idea of it was revealed to me in a dream
        public void Main() 
        {
            Console.WriteLine("LanguageGenerator");
        }

        public void GenerateSyllables()
        {


        }

        public void GenerateInclination()
        { 
            
        }

        
    }
}
