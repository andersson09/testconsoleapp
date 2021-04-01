using NUnit.Framework;
using test.console;

namespace Test.Nunit
{
    [TestFixture]
    public class TestServiceTest
    {
        [Test]
        public void Bob()
        {
            var service = new TestService();
            var result = service.Run("Bobz");

            Assert.AreEqual("Hello Bob", result);
            Assert.AreEqual("a", "b");
            Assert.IsTrue(false);
        }

        [Test]
        public void Alice()
        {
            var service = new TestService();
            

            var result = service.Run("Bob");

            Assert.AreEqual("Hello Bob", result);
        }
    }
}