using ResultPatternSample.Core;

namespace ResultPatternSample.Services;

public class CalculatorService
{
    public Result<double> Divide(double dividend, double divisor)
    {
        if (divisor == 0)
            return Result<double>.Fail("Divisor cannot be zero.");

        double result = dividend / divisor;
        return Result<double>.Ok(result);
    }
}
