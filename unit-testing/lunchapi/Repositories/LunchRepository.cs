using lunchapi.Models;

namespace lunchapi.Repositories;


public class LunchRepository : ILunchRepository
{
    public List<Lunch> GetLunch()
    {
        var lunchList = new List<Lunch>
        {
            new Lunch()
            {
                name = "Pizza",
                price = 15.99M,
                quantity = 1
            },
            new Lunch()
            {
                name = "MoMo",
                price = 12.99M,
                quantity = 10
            }
        };
        return lunchList;
    }
}