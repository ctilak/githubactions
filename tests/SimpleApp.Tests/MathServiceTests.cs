using Xunit;
using SimpleApp;

namespace SimpleApp.Tests
{
    public class MathServiceTests
    {
        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(1, 2, 3)]
        [InlineData(-5, 5, 0)]
        public void Add_ReturnsExpected(int a, int b, int expected)
        {
            var result = MathService.Add(a, b);
            Assert.Equal(expected, result);
        }
    }
}
