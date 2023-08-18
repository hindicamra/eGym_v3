using AutoMapper;
using eGym.BLL.Models;
using eGym.BLL.Models.Requests;
using eGym.DAL;
using eGym.Domain;

namespace eGym.BLL.Implementation;

public class FeedbackService : IFeedbackService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public FeedbackService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task Create(CreateFeedbackRequest request)
    {
        await _unitOfWork.Feedbacks.Insert(_mapper.Map<Feedback>(request));
    }
    public async Task Delete(int id)
    {
        await _unitOfWork.Feedbacks.Delete(id);
    }

    public async Task Update(UpdateFeedbackRequest request, FeedbackDTO feedback)
    {
        var updatedFeedback = _mapper.Map(request, feedback);
        await _unitOfWork.Feedbacks.Update(_mapper.Map<Feedback>(updatedFeedback));
    }

    public async Task<FeedbackDTO> GetById(int id)
    {
        var result = await _unitOfWork.Feedbacks.GetById(id);

        var user = await _unitOfWork.Accounts.GetById(result.AccountId);

        var response = _mapper.Map<FeedbackDTO>(result);
        response.Username = user.Username;

        return response;
    }

    public async Task<List<FeedbackDTO>> GetAll()
    {
        var result = await _unitOfWork.Feedbacks.GetAll();

        var response = _mapper.Map<List<FeedbackDTO>>(result);

        foreach(var x in response)
        {
            var user = await _unitOfWork.Accounts.GetById(x.AccountId);

            x.Username = user.Username;
        }

        return response;
    }

    public async Task<List<FeedbackDTO>> GetByUser(int userId)
    {
        var result = await _unitOfWork.Feedbacks.GetWhere(x => x.AccountId.Equals(userId));

        var response = _mapper.Map<List<FeedbackDTO>>(result);

        foreach (var x in response)
        {
            var user = await _unitOfWork.Accounts.GetById(x.AccountId);

            x.Username = user.Username;
        }

        return response;
    }
}