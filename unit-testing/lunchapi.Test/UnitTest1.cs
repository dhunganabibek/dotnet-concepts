using lunchapi.Services;
using lunchapi.Controllers;
using lunchapi.Models;
using Microsoft.AspNetCore.Mvc;


namespace lunchapi.Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        //Arrange
        var _service = new LunchService();
        var _controller = new LunchController(_service);

        //Act
        var data = _controller.GetLunch();
        var datatype = data as OkObjectResult;
        var datalist = datatype.Value as List<Lunch>;
        // Assert
        Assert.NotNull(data);
        Assert.IsType<List<Lunch>>(datatype.Value);
        Assert.Equal(2, datalist.Count);

    }
}