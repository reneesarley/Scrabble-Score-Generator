
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScore;
using System.Collections.Generic;
using System;

namespace ScrabbleScoreTests
{
    [TestClass]
    public class WordTest
	{
        [TestMethod]
        public void GetSetWordToScore_SetValueOfWordToScore_String()
        {
            //Arrange
             string testWord = "Car";
             Word newWord = new Word();

            //Act
            newWord.SetWordToScore(testWord);
            string result = newWord.GetWordToScore();

            //Assert
            Assert.AreEqual(result, testWord);
        } 
        [TestMethod]
        public void GetWordScore_ReturnsWordScore_Int()
        {
            //Arrange
            Word newWord = new Word();

            //Act
            int result = newWord.GetWordScore();

            //Assert
            Assert.AreEqual(0, result);

        }
        [TestMethod]
        public void GetLetterValues_LetterValues_Int()
        {
            //Arrange
            char testLetter = 'a';
            Word newWord = new Word();

            //Act
            int result = newWord.GetLetterValue(testLetter);


            //Assert
            Assert.AreEqual(result, 1);
        }
	}
}
