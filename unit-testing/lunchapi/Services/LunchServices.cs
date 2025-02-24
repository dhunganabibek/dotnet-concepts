using lunchapi.Models;
using lunchapi.Repositories;

namespace lunchapi.Services;

public class LunchService
{
    private readonly ILunchRepository _lunchRepository;

    public LunchService(ILunchRepository lunchRepository)
    {
        _lunchRepository = lunchRepository;
    }

    public List<Lunch> GetLunch()
    {
        var data = _lunchRepository.GetLunch();
        return data;
    }
}