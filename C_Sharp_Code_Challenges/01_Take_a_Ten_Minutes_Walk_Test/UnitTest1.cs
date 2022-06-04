using _01_Take_a_Ten_Minutes_Walk;
using NUnit.Framework;

namespace _01_Take_a_Ten_Minutes_Walk_Test
{
    public class Tests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(true, Kata.IsValidWalk(new string[] { "n", "s", "n", "s", "n", "s", "n", "s", "n", "s" }), "should return true");
            Assert.AreEqual(false, Kata.IsValidWalk(new string[] { "w", "e", "w", "e", "w", "e", "w", "e", "w", "e", "w", "e" }), "should return false");
            Assert.AreEqual(false, Kata.IsValidWalk(new string[] { "w" }), "should return false");
            Assert.AreEqual(false, Kata.IsValidWalk(new string[] { "n", "n", "n", "s", "n", "s", "n", "s", "n", "s" }), "should return false");
        }
    }
}