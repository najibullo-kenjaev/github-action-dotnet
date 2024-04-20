using Hamsafar.Services;

namespace Hamsafar.Tests;

public class BasicMathsTest
{
    [Fact]
    public void Test_AddMethod()
    {
        BasicMaths bm = new BasicMaths();
        double res = bm.Add(10, 10);
        Assert.Equal(res, 20);
    }
    [Fact]
    public void Test_SubstractMethod()
    {
        BasicMaths bm = new BasicMaths();
        double res = bm.Substract(20, 20);
        Assert.Equal(res, 0);
    }
    [Fact]
    public void Test_DivideMethod()
    {
        BasicMaths bm = new BasicMaths();
        double res = bm.divide(10, 5);
        Assert.Equal(res, 2);
    }
    [Fact]
    public void Test_MultiplyMethod()
    {
        BasicMaths bm = new BasicMaths();
        double res = bm.Multiply(10, 10);
        Assert.Equal(res, 20);
    }
}