using eGym.BLL.Models;
using eGym.BLL.Models.Requests;

namespace eGym.BLL;

public interface IFeedbackService
{
    public Task<FeedbackDTO> GetById(int id);
    public Task Delete(int id);
    public Task Create(CreateFeedbackRequest request);
    public Task Update(UpdateFeedbackRequest request, FeedbackDTO feedback);
    public Task<List<FeedbackDTO>> GetAll();
    public Task<List<FeedbackDTO>> GetByUser(int userId);
}
