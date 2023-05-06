using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class WordSmithTest
    {
        [Theory]
        [InlineData("racecar", true)]
		[InlineData("tacocat", true)]
		[InlineData("boonies", false)]
		[InlineData("dinner", false)]
		public void Wordsmith1(string word, bool expected)
        {   //arrange
            var palendrome = new WordSmith();
            //act
            var actual = palendrome.IsPalendrome(word);
            //assert
            Assert.Equal(expected, actual);
        }
    }
}
