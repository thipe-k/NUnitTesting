using NUnit.Framework;
using NUnitTesting;
namespace Tests
{
    public class StringManupulationTest
    {
        [Test]
        public void TextIsDigit()
        {
            StringManipulator stringManipulator = new StringManipulator();
            bool? result = stringManipulator.IsDegit("5");
            Assert.That(result, Is.True);
        }
    }
}
