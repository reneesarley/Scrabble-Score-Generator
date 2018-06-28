using System;
using System.Collections.Generic;

namespace ScrabbleScore
{
    public class Word
    {
        private string _wordToScore;
        private int _wordScore;
        private Dictionary<char, int> _letterValues = new Dictionary<char, int>(){};
        private List<char> _onePointLetters = new List<char>() {'a', 'e', 'i', 'o', 'u', 'l', 'n', 'r', 's', 't'};

        public Word()
        {
            _wordScore = 0;
            this.BuildLetterValueDictionary(_onePointLetters, 1);

        }
        public void BuildLetterValueDictionary(List<char >pointList, int pointValue)
        {
            for (int i = 0; i < pointList.Count; ++i)
            {
                _letterValues[pointList[i]] = pointValue;
            } 
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
