using System.Diagnostics.CodeAnalysis;
using UserInput.Code;
using Xunit;

namespace UserInput.Tests
{
    [SuppressMessage("ReSharper", "ConvertToConstant.Local")]
    public class TextInputTests
    {
        [Fact]
        public void TextInput_AddVariousCharacters_ReturnsCorrectValue()
        {
            var textInput = new TextInput();
            textInput.Add('1');
            textInput.Add('a');
            textInput.Add('0');

            var expected = "1a0";
            var actual = textInput.GetValue();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void NumericInput_AddNumericCharacters_ReturnsCorrectValue()
        {
            var textInput = new NumericInput();
            textInput.Add('1');
            textInput.Add('0');

            var expected = "10";
            var actual = textInput.GetValue();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void NumericInput_AddVariousCharacters_ReturnsCorrectValue()
        {
            var textInput = new NumericInput();
            textInput.Add('1');
            textInput.Add('a');
            textInput.Add('0');

            var expected = "10";
            var actual = textInput.GetValue();

            Assert.Equal(expected, actual);
        }
    }
}
