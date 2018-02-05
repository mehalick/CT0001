using System;

namespace UserInput.Code
{
    // TODO: implement TextInput and NumericInput to pass unit tests

    public class TextInput
    {
        public void Add(char c)
        {
            throw new NotImplementedException();
        }

        public string GetValue()
        {
            throw new NotImplementedException();
        }
    }

    public class NumericInput : TextInput
    {
    }

    internal class Program
    {
        private static void Main()
        {
            TextInput input = new NumericInput();
            input.Add('1');
            input.Add('a');
            input.Add('0');

            Console.WriteLine(input.GetValue());
        }
    }
}
