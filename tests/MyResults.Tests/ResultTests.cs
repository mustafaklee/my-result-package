using FluentAssertions;
using System.Diagnostics.CodeAnalysis;
using Xunit;
namespace MyResults.Tests;

public class ResultTests
{
    [Fact]
    public void Result_Should_Set_Properties()
    {
        var r = new Result(true, "ok");
        r.Success.Should().BeTrue();
        r.Message.Should().Be("ok");
    }

    [Fact]
    public void SuccessResult_Should_Always_Be_Success()
    {
        var r = new SuccesResult("done");
        r.Success.Should().BeTrue();
        r.Message.Should().Be("done");
    }

    [Fact]
    public void ErrorResult_Should_Always_Be_False()
    {
        var r = new ErrorResult(false,"bad");
        r.Success.Should().BeFalse();
        r.Message.Should().Be("bad");
    }

    [Theory]
    [InlineData(default!)]
    [InlineData("")]
    [InlineData("custom message")]
    public void Result_Message_Cant_Be_NullOrEmpty(string message)
    {
        var r = new Result(true, message);
        r.Message.Should().Be(message);
    }
}
