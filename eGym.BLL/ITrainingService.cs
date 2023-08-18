using eGym.BLL.Models;
using eGym.BLL.Models.Requests;

namespace eGym.BLL;

public interface ITrainingService
{
    public Task<List<TrainingDTO>> GetUserTraningPlan(int userId);
    public Task<TrainingDTO> GetById(int id);
    public Task Create(CreateTrainingRequest request);
    public Task Update(UpdateTrainingRequest request, TrainingDTO traning);
    public Task Delete(int Id);
}