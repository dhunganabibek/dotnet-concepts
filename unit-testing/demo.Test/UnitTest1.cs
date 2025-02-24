using demo;

namespace demo.Test;

public class UnitTest
{

    [Fact]
    public void TestAdd()
    {
        // Arrange
        var calculator = new Calculator();
        // Act
        var result = calculator.Add(50000, 500000);
        var result2 = calculator.Add(-5, 10);
        var result3 = calculator.Add(0, 10);
        // Assert
        Assert.Equal(100000, result);
        Assert.Equal(5, result2);
        Assert.Equal(10, result3);
    }

    [Fact]
    public void TestSub()
    {
        System.Console.WriteLine("This is from test 2");
    }
}