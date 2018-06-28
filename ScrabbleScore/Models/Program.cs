//using ScrabbleScore;
//using System.Collections.Generic;
using System;

namespace ScrabbleScore
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a word to get its Scrabble score");
            string usersWord = Console.ReadLine();
            Word newWord = new Word();
            newWord.SetWordToScore(usersWord);
            newWord.ConvertWordToArrayAndLower();
            Console.WriteLine("{0} is the score for {1}", newWord.GetWordScore(), usersWord);

        }
    }
}
