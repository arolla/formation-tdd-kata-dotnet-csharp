using Xunit;

namespace Arolla.TDDFormation.Test.Xunit
{
    public class ExampleClassTest
    {
        private readonly ExampleClass _exampleClass;

        public ExampleClassTest()
        {
            _exampleClass = new ExampleClass();
        }

        [Fact]
        public void ExampleTest()
        {
            // Given / Arrange
            const int expectedValue = 1;

            // When / Act
            var actual = _exampleClass.GetOne();

            // Then / Assert
            Assert.Equal(expectedValue, actual);
        }
    }
}
