using NUnit.Framework;
using FizzBuzz;

namespace FizzBuzzNUnitTest
{
    [TestFixture]
    public class When_We_Have_IsDivisibleBy
    {
        [TestCase(1, 3, false)]
        [TestCase(2, 3, false)]
        [TestCase(3, 3, true)]
        [TestCase(6, 3, true)]
        [TestCase(9, 3, true)]
        [TestCase(10, 3, false)]
        [TestCase(1, 4, false)]
        [TestCase(2, 4, false)]
        [TestCase(3, 4, false)]
        [TestCase(4, 4, true)]
        [TestCase(5, 4, false)]
        public void Then_IsDivisibleBy_Works(int x, int y, bool isDivisible)
        {
            bool result = Program.IsDivisibleBy(x, y);
            Assert.That(result, Is.EqualTo(isDivisible));
        }
    }
}