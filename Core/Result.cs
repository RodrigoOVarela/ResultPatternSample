namespace ResultPatternSample.Core;

public class Result
{
    public bool Success { get; }
    public string? Error { get; }

    public bool Failure => !Success;

    protected Result(bool success, string? error)
    {
        Success = success;
        Error = error;
    }

    public static Result Ok() => new(true, null);

    public static Result Fail(string error) => new(false, error);
}

public class Result<T> : Result
{
    public T? Value { get; }

    private Result(T value) : base(true, null)
    {
        Value = value;
    }

    private Result(string error) : base(false, error) { }

    public static Result<T> Ok(T value) => new(value);

    public static new Result<T> Fail(string error) => new(error);
}
