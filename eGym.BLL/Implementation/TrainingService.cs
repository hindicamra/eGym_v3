using AutoMapper;
using eGym.BLL.Models;
using eGym.BLL.Models.Requests;
using eGym.DAL;
using eGym.Domain;

namespace eGym.BLL.Implementation;

public class TraningService : ITrainingService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

	public TraningService(IUnitOfWork unitOfWork, IMapper mapper)
	{
        _mapper = mapper;
        _unitOfWork = unitOfWork;
	}

    public async Task Create(CreateTrainingRequest request)
    {
        await _unitOfWork.Trainings.Insert(_mapper.Map<Training>(request));
    }

    public async Task Delete(int id)
    {
        await _unitOfWork.Trainings.Delete(id);
    }

    public async Task<TrainingDTO> GetById(int id)
    {
        var result = await _unitOfWork.Trainings.GetById(id);
        return _mapper.Map<TrainingDTO>(result);
    }

    public async Task<List<TrainingDTO>> GetUserTraningPlan(int userId)
    {
        var result = await _unitOfWork.Trainings.GetWhere(x => x.AccountId.Equals(userId));
        return _mapper.Map<List<TrainingDTO>>(result);
    }

    public async Task Update(UpdateTrainingRequest request, TrainingDTO traning)
    {
        var updatedTraning = _mapper.Map(request, traning);
        await _unitOfWork.Trainings.Update(_mapper.Map<Training>(updatedTraning));
    }
}

