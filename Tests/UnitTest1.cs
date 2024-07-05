using Lib;

namespace Tests;

public class UnitTest1
{
    [Theory]
    [InlineData(1, 2, 3)]
    public void Test1(int a, int b, int result)
    {
        Assert.Equal(result, Addition.Add(a, b));
    }
}