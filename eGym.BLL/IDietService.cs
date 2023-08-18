using System;
using eGym.BLL.Models;
using eGym.BLL.Models.Requests;

namespace eGym.BLL;

public interface IDietService
{
    public Task<DietDTO> GetById(int id);
    public Task<List<DietDTO>> GetByUser(int userId);
    public Task Delete(int id);
    public Task Create(CreateDietRequest request);
    public Task Update(UpdateDietRequest request, DietDTO diet);
}

