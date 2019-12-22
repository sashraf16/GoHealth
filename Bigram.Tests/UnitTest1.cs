using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using GoHealth;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Program program =  new Program();

            var result = program.ClearString(@"../test.txt");
            var expectedresult = "the quick brown dog jumped over the quick lazy fox and then the quick and the quick";

            Assert.AreEqual(expectedresult, result);
        }
    }
}