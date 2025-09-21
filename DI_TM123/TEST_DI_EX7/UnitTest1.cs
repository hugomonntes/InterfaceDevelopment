using DI_EX7;
namespace TEST_DI_EX7
{
    public class Tests
    {
        private Planeta tierra;

        [SetUp]
        public void Setup()
        {
            tierra = new Planeta();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}