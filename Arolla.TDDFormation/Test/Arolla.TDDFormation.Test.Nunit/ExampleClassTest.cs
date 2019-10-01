using NUnit.Framework;

namespace Arolla.TDDFormation.Test.Nunit
{
    public class ExampleClassTest
    {
        private readonly ExampleClass _exampleClass;

        public ExampleClassTest()
        {
            _exampleClass = new ExampleClass();
        }

        [Test]
        public void ExampleTest()
        {
            // Given / Arrange
            const int expectedValue = 1;

            // When / Act
            var actual = _exampleClass.GetOne();

            // Then / Assert
            Assert.AreEqual(expectedValue, actual);
        }
    }
}
