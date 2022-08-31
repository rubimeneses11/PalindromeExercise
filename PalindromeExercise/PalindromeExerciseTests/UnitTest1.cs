using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory] //theory 
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        [InlineData("Racecar", true)]
        [InlineData("goodbye", false)]
        [InlineData("madam", true)] //inline data
        public void Test(string word, bool expected) //test method
        {
            //arrange
            var test = new WordSmith();

            //act
            var actual = test.IsAPalindrome(word);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
