using System;
using System.Collections.Generic;

namespace ScrabbleScore
{
    public class Word
    {
        private string _wordToScore;
        private int _wordScore;
        private Dictionary<char, int> _letterValues = new Dictionary<char, int>(){};

        public Word()
        {
            _wordScore = 0;
            _letterValues['a'] = 1;
        }

        public void SetWordToScore(string usersWord)
        {
            _wordToScore = usersWord; 
        }
        public string GetWordToScore()
        {
            return _wordToScore;
        }

        public int GetWordScore()
        {
            return _wordScore;
        }
        public int GetLetterValue(char letter)
        {
            return _letterValues[letter];
        }

    }
}
