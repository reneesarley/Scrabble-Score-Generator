using System;

namespace ScrabbleScore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word to get its Scrabble score");
            string usersWord = Console.ReadLine();
            Word newWord = new Word();
            newWord.SetWordToScore(usersWord);


        }
    }
}
