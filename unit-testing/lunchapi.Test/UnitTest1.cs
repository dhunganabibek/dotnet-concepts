using lunchapi.Services;
using lunchapi.Controllers;
using lunchapi.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using lunchapi.Repositories;


namespace lunchapi.Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        //Arrange
        var mockRepo = new Mock<ILunchRepository>();
        mockRepo.Setup(repo => repo.GetLunch()).Returns(new List<Lunch>{
            new Lunch { name = "Burger", price = 10.99M, quantity = 10 },
            new Lunch { name = "Pasta", price = 8.99M, quantity = 1 }
        });

        var lunchService = new LunchService(mockRepo.Object);
        var result = lunchService.GetLunch();

        // Assert
        Assert.Equal(2, result.Count);
        Assert.Contains(result, lunch => lunch.name == "Burger");




        // //Arrange
        // var _service = new LunchService();
        // var _controller = new LunchController(_service);

        // //Act
        // var data = _controller.GetLunch();
        // var datatype = data as OkObjectResult;
        // var datalist = datatype.Value as List<Lunch>;
        // // Assert
        // Assert.NotNull(data);
        // Assert.IsType<List<Lunch>>(datatype.Value);
        // Assert.Equal(2, datalist.Count);

    }
}