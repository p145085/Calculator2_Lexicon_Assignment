namespace TestProject2;

public class CalcTests
{
    [Theory]
    [InlineData(3, 1, 4)]
    public void Addition(double x, double y, double expected)
    {
        double actual = x + y;
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(1, -1, 2)]
    public void Subtraction(double x, double y, double expected)
    {
        double actual = x - y;
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(5, 2, 2.5)]
    public void Division(double x, double y, double expected)
    {
        double actual = x / y;
        Assert.Equal(expected, actual);
    }
    [Theory]
    [InlineData(4, 2, 8)]
    public void Multiplication(double x, double y, double expected)
    {
        double actual = x * y;
        Assert.Equal(expected, actual);
    }
}