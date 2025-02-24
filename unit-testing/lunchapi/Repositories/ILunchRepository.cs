using lunchapi.Models;

namespace lunchapi.Repositories;

public interface ILunchRepository
{
    List<Lunch> GetLunch();
}