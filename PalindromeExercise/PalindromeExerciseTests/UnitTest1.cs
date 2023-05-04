using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class IsAPalindromeTest
    {
        [Theory]
        [InlineData("civic", true)]
        [InlineData("radar", true)]
        [InlineData(" katherine", false)]
        [InlineData("madam", true)]

        public void isAPalidromeTest(string word, bool expected)
        {
            //  arrange 
            var isAPali = new WordSmith();

            // act

            var actual = isAPali.IsAPalidrone(word,expected);

            // assert

            Assert.Equal(expected, actual);



        }

    }                                                               // ← you will need to put some test data and expected result here.

    //arrange




}
