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
        var val1 = 50000;
        var val2 = 50000;
        var positiveResult = val1 + val2;
        var result = calculator.Add(val1, val2);


        var result2 = calculator.Add(-5, 10);


        var result3 = calculator.Add(0, 10);
        // Assert
        //Assert.Equal(10000, result);
        Assert.True(result == positiveResult, $"Expected , but got {result}. Possible miscalculation in the addition.");
        Assert.Equal(5, result2);
        Assert.Equal(10, result3);
    }

    [Fact]
    public void TestSub()
    {
        System.Console.WriteLine("This is from test 2");
    }
}