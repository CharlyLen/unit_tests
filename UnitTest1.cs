using Mocking;
using Moq;
using NUnit.Framework;

namespace MockTesting
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {}

        [Test]
        public void TestCaseForImplementedMethod()
        {
            var mock = new Mock<Repository>();
            Business business = new Business(mock.Object);
            Assert.AreEqual(4, business.Addition(2,2));
        }
    }
}