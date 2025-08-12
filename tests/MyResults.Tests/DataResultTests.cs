using FluentAssertions;
using System.Diagnostics.CodeAnalysis;
using Xunit;
namespace MyResults.tests.MyResults.Tests
{
    public class DataResultTests
    {
        [Fact]
        public void DataResult_Should_Carry_Data_And_Status()
        {
            var r = new DataResult<int>(42, true, "ok");
            r.Data.Should().Be(42);
            r.Success.Should().BeTrue();
            r.Message.Should().Be("ok");
        }

        [Fact]
        public void SuccessDataResult_Should_Set_Success_True()
        {
            var r = new SuccessDataResult<string>("hello", "great");
            r.Success.Should().BeTrue();
            r.Data.Should().Be("hello");
            r.Message.Should().Be("great");
        }

        [Fact]
        public void ErrorDataResult_Should_Set_Success_False()
        {
            var r = new ErrorDataResult<object?>(null, false, "err");
            r.Success.Should().BeFalse();
            r.Data.Should().BeNull();
            r.Message.Should().Be("err");
        }

        [Theory]
        [InlineData(0)]
        [InlineData(123)]
        public void Generic_Data_Should_Roundtrip(int value)
        {
            var r = new SuccessDataResult<int>(value);
            r.Data.Should().Be(value);
        }
    }
}
