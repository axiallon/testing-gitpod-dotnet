using NUnit.Framework;

namespace testing_gitpod_dotnet
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int result = 1 + 1;
            Assert.AreEqual(2, result);
        }
    }
}