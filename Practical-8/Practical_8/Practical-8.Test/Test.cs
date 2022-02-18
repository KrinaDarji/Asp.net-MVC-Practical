using NUnit.Framework;
namespace Practical_8.Test
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void teststring()
        {
            var s = new Helloworldtest();
            Assert.That(s.hello(), Is.EqualTo("Hello World"));
        }

    }
}
