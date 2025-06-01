using ResultPatternSample.Core;

namespace ResultPatternSample.Tests;

public class ResultTests
{
    [Fact]
    public void Ok_Should_Create_Success_Result()
    {
        var result = Result.Ok();

        Assert.True(result.Success);
        Assert.Null(result.Error);
        Assert.False(result.Failure);
    }

    [Fact]
    public void Fail_Should_Create_Failure_Result()
    {
        var errorMsg = "Error occurred";
        var result = Result.Fail(errorMsg);

        Assert.False(result.Success);
        Assert.Equal(errorMsg, result.Error);
        Assert.True(result.Failure);
    }

    [Fact]
    public void Ok_Should_Create_Success_Result_With_Value()
    {
        var value = 123;
        var result = Result<int>.Ok(value);

        Assert.True(result.Success);
        Assert.Null(result.Error);
        Assert.False(result.Failure);
        Assert.Equal(value, result.Value);
    }

    [Fact]
    public void Fail_Should_Create_Failure_Result_With_Error()
    {
        var errorMsg = "Value error";
        var result = Result<int>.Fail(errorMsg);

        Assert.False(result.Success);
        Assert.Equal(errorMsg, result.Error);
        Assert.True(result.Failure);
    }
}
