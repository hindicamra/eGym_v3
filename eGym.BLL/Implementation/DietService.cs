using System;
using AutoMapper;
using eGym.BLL.Models;
using eGym.BLL.Models.Requests;
using eGym.DAL;
using eGym.Domain;

namespace eGym.BLL.Implementation;

public class DietService : IDietService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

	public DietService(IUnitOfWork unitOfWork, IMapper mapper)
	{
        _unitOfWork = unitOfWork;
        _mapper = mapper;
	}

    public async Task Create(CreateDietRequest request)
    {
        await _unitOfWork.Diets.Insert(_mapper.Map<Diet>(request));
    }

    public async Task Delete(int id)
    {
        await _unitOfWork.Diets.Delete(id);
    }

    public async Task Update(UpdateDietRequest request, DietDTO diet)
    {
        var updatedDiet = _mapper.Map(request, diet);
        await _unitOfWork.Diets.Update(_mapper.Map<Diet>(updatedDiet));
    }

    public async Task<DietDTO> GetById(int id)
    {
        var result = await _unitOfWork.Diets.GetById(id);
        return _mapper.Map<DietDTO>(result);
    }

    public async Task<List<DietDTO>> GetByUser(int userId)
    {
        var result = await _unitOfWork.Diets.GetWhere(x => x.AccountId.Equals(userId));
        return _mapper.Map<List<DietDTO>>(result);
    }
}

