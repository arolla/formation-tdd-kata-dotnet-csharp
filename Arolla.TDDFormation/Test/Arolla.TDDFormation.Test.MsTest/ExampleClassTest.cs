using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Arolla.TDDFormation.Test.MsTest
{
    [TestClass]
    public class ExampleClassTest
    {
        private ExampleClass _exampleClass;

        [TestInitialize]
        public void Initialize()
        {
            _exampleClass = new ExampleClass();
        }

        [TestMethod]
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
