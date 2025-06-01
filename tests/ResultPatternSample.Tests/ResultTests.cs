using FluentAssertions;
using ResultPatternSample.Core;

namespace ResultPatternSample.Tests;

public class ResultTests
{
    [Fact]
    public void Ok_Should_Create_Success_Result()
    {
        var result = Result.Ok();

        result.Success.Should().BeTrue();
        result.Error.Should().BeNull();
        result.Failure.Should().BeFalse();
    }

    [Fact]
    public void Fail_Should_Create_Failure_Result()
    {
        var errorMsg = "Error occurred";
        var result = Result.Fail(errorMsg);

        result.Success.Should().BeFalse();
        result.Error.Should().Be(errorMsg);
        result.Failure.Should().BeTrue();
    }

    [Fact]
    public void Ok_Should_Create_Success_Result_With_Value()
    {
        var value = 123;
        var result = Result<int>.Ok(value);

        result.Success.Should().BeTrue();
        result.Error.Should().BeNull();
        result.Failure.Should().BeFalse();
        result.Value.Should().Be(value);
    }

    [Fact]
    public void Fail_Should_Create_Failure_Result_With_Error()
    {
        var errorMsg = "Value error";
        var result = Result<int>.Fail(errorMsg);

        result.Success.Should().BeFalse();
        result.Error.Should().Be(errorMsg);
        result.Failure.Should().BeTrue();
    }
}
