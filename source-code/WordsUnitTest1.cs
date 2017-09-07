using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Words;

namespace WordsUnitTests
{
    [TestClass]
    public class WordsUnitTest1
    {
        [TestMethod]
        public void LetterCounterTest()
        {
            // Assemble
            char letter = Convert.ToChar("i");
            int expectedResult = 6;
            String sentence = "iiiiioi";
            LetterCounter letterCounter = new LetterCounter();

            // Act
            int actualResult = LetterCounter.LetterCount(sentence, letter);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void PalindromeCheckerIsNotTest()
        {
            // Assemble
            String value = "I have some cheese";
            bool expectedResult = false;
            PalindromeChecker palindromeChecker = new PalindromeChecker();

            // Act
            bool actualResult = PalindromeChecker.PalindromeCheck(value);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void PalindromeCheckerIsTest()
        {
            // Assemble
            String value = "God saved Eva's dog";
            bool expectedResult = true;
            PalindromeChecker palindromeChecker = new PalindromeChecker();

            // Act
            bool actualResult = PalindromeChecker.PalindromeCheck(value);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        public void CensoredWordCounterTest()
        {
            // Assemble
            String sentence = "I have a cat named Meow and a dog named Woof.I love the dog a lot. He is larger than a small horse.";
            int expectedResult = 4;

            // Act
            int actualResult = CensoredWordCounter.CensoredWordCount(sentence);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }



        [TestMethod]
        public void CensoredPalindromesTest()
        {
            // Assemble
            String w2 = "Anna went to vote in the election to fulfil her civic duty";
            bool expectedResult = true;

            // Act
            bool actualResult = CensorPalindromes.CensoringPalindromes(w2);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
