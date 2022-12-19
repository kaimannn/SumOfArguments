global using Xunit;
using SumOfArguments.ConsoleApp.Extensions;

namespace SumOfArguments.Tests
{
    public class SumTests
    {
        [Theory]
        [InlineData("1", "2", "3")]
        [InlineData("10", "20", "30")]
        [InlineData("-1", "-2", "-3")]
        [InlineData("1.3", "2.5", "3.8")]
        [InlineData("10.99", "20.99", "31.98")]
        [InlineData("-1", "-2.1", "-3.1")]
        [InlineData("hello", "world", "helloworld")]
        [InlineData("foo", "bar", "foobar")]
        [InlineData("fc", "b", "fcb")]
        public void TestSumOfArguments(string a, string b, string result)
        {
            var sumModel = a.Sum(b);
            Assert.Equal(result, sumModel.Result);
        }
    }
}