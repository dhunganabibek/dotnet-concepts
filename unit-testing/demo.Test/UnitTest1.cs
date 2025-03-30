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
        var expectedPositiveResult = val1 + val2;
        var result = calculator.Add(val1, val2);


        var result2 = calculator.Add(-5, 10);


        var result3 = calculator.Add(0, 10);
        // Assert
        //Assert.Equal(10000, result);
        Assert.True(result == expectedPositiveResult, $"Expected , but got {result}. Possible miscalculation in the addition.");
        Assert.Equal(5, result2);
        Assert.Equal(10, result3);
    }

    [Theory]
    [InlineData(10, 5, 5)]
    [InlineData(2, 3, -1)]
    [InlineData(0, 0, 0)]
    public void TestSub(int input1, int input2, int expectedResult)
    {
        // Arrange 
        var calculator = new Calculator();

        // act
        var result = calculator.Sub.Compile()(input1, input2);

        // Assert 
        Assert.True(result == expectedResult);
    }
}