using FluentAssertions;
using NUnit.Framework;

namespace FizzBuzz_20180222_1
{
    [TestFixture]
    public class BarTests
    {
        [Test, Category("Unit")]
        public void GivenFoo_WhenBarring_ThenItShouldBaz()
        {
            // arrange

            // act

            // assert
            1.ToString().Should().Be("1");
        }
    }
}