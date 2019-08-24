using System;
using System.Collections.Generic;
using System.Linq;

namespace LetterLoopin
{
    class Program
    {
        static void Main(string[] args)
        {
            string capitalizeThisString(string stringToCapitalize)
            {
                return stringToCapitalize.First().ToString().ToUpper() + stringToCapitalize.Substring(1);
            }

            List<string> LoopThruLetters(string phraseToLoop)
            {
                List<string> chars = new List<string>();
                for(var i = 0; i < phraseToLoop.Length; i ++)
                {
                    var repeatedChar = string.Concat(Enumerable.Repeat(phraseToLoop[i], (i + 1)));
                    var capitalizedString = capitalizeThisString(repeatedChar);
                    chars.Add(capitalizedString);
                }
                return chars;
            }

            Console.WriteLine("Insert a phrase with no spaces!");
            var phrase = Console.ReadLine().ToLower();
            var phraseToPrint = LoopThruLetters(phrase);
            Console.WriteLine(String.Join("-", phraseToPrint));
        }
    }
}
