using System;
using System.Linq;

namespace Problems.Services
{
    public class LanguageGenerator
    {
        // this is the code equivalent of having AIDS, rewrite it!
        private string[] _vowels = new string[]{"a", "e", "y", "u", "i", "o"};
        private string[] _consonants = new string[]{"q", "w", "r", "t", "p", "s", "d", "f", "g", "h",
        "j", "k", "l", "z", "x", "c", "v", "b", "n", "m"};

        private Dictionary<string, List<string>> _syllables = new Dictionary<string, List<string>>()
        {
            {"vc", new List<string>()},
            {"cv", new List<string>()},
            {"cvc", new List<string>()},
        };

        private Dictionary<string, string> _pronouns = new Dictionary<string, string>()
        {
            {"I", ""},
            {"You", ""},
            {"He", ""},
            {"She", ""},
            {"It", ""},
            {"We", ""},
            {"They", ""}
        };

        private Dictionary<string, string> _inclinations = new Dictionary<string, string>()
        {
            {"I|present", ""},
            {"You|present", ""},
            {"He|present", ""},
            {"She|present", ""},
            {"It|present", ""},
            {"We|present", ""},
            {"They|present", ""},
            {"prular", ""}
        };

        // the idea of it was revealed to me in a dream
        public void Main() 
        {
            Console.WriteLine("LanguageGenerator");
            GenerateSyllables();
            var s = _syllables;
        }

        public void GenerateSyllables()
        {
            foreach(var cOne in _consonants)
            {
                foreach(var v in _vowels)
                {
                    _syllables["vc"].Add(v + cOne);
                    _syllables["cv"].Add(cOne + v);
                    foreach(var cTwo in _consonants)
                    {
                        _syllables["cvc"].Add(cOne + v + cTwo);
                    }
                }
            }

        }

        public string GetRandomSyllable()
        {
            var i = Random.Next(0,3);
            var syllable = _syllables.EllementAt(i).value[Random.Next(0, _syllables.EllementAt(i).value.Count)];
            return syllable;
        }

        public string GetRandomWord()
        {
            return "";
        }

        public void GenerateInclinationAndPronouns()
        { 
            
        }

        
    }
}
