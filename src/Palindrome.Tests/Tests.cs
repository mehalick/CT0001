using System;
using Xunit;

namespace Palindrome.Tests
{
    public class Tests
    {
        [Fact]
        public void IsPalindrome_NullInput_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => Code.Program.IsPalindrome(null));
        }

        [Fact]
        public void IsPalindrome_EmptyInput_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => Code.Program.IsPalindrome(""));
        }

        [Fact]
        public void IsPalindrome_SingleCasePalindrome_ReturnsTrue()
        {
            var isPalindrome = Code.Program.IsPalindrome("racecar");

            Assert.True(isPalindrome);
        }

        [Fact]
        public void IsPalindrome_MixedCasePalindrome_ReturnsTrue()
        {
            var isPalindrome = Code.Program.IsPalindrome("RACEcar");

            Assert.True(isPalindrome);
        }

        [Fact]
        public void IsPalindrome_NonPalindrome_ReturnsFalse()
        {
            var isPalindrome = Code.Program.IsPalindrome("firetruck");

            Assert.False(isPalindrome);
        }
    }
}
