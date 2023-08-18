using eGym.BLL.Models;

namespace eGym.BLL;

public interface IRecommendationService
{
    public Task<List<Recommendation>> Get(int accountId);
}

