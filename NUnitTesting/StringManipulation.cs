
namespace NUnitTesting
{
    public interface IStringManipulation
    {
        public bool? IsWord(string text);
        public bool? IsDegit(string text);

        public string ReserveWord(string text);

        public bool IsConvertableToDate(string text);
    }
}
