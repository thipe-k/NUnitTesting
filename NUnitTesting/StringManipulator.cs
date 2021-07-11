using System;
using System.Text.RegularExpressions;

namespace NUnitTesting
{
    public class StringManipulator : IStringManipulation
    {
        public bool IsConvertableToDate(string text)
        {
            throw new NotImplementedException();
        }

        public bool? IsDegit(string text)
        {
            Regex regex = new Regex("[0-9]");
            return regex.IsMatch(text);
        }

        public bool? IsWord(string text)
        {
            Regex regex = new Regex("[a-zA-Z]");
            return regex.IsMatch(text);
        }

        public string ReserveWord(string text)
        {
            return null;
        }
    }
}
