using NUnit.Framework;

namespace Testing.Question
{
    public class OddServiceTests
    {

        [Test]
        public void TestTrue()
        {
            int[] input = new int[] { 1, 2, 34, 3, 4, 5, 7, 23, 12 };
            OddService service = new OddService();
            bool result = service.HasThreeConsecutiveOdds(input);
            Assert.True(result);
        }

        [Test]
        public void TestFalse()
        {
            int[] input = new int[] { 2, 6, 4, 1 };
            OddService service = new OddService();
            bool result = service.HasThreeConsecutiveOdds(input);
            Assert.False(result);
        }

    }
}