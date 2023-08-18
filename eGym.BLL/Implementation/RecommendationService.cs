using eGym.BLL.Models;
using eGym.BLL.Models.Enums;
using eGym.DAL;

namespace eGym.BLL.Implementation;

public class RecommendationService : IRecommendationService
{
    private readonly IUnitOfWork _unitOfWork;

	public RecommendationService(IUnitOfWork unitOfWork)
	{
        _unitOfWork = unitOfWork;
	}

    public async Task<List<Recommendation>> Get(int accountId)
    {
        var accountReservations = await _unitOfWork.Reservations.GetWhere(x => x.AccountId.Equals(accountId));

        var recommendations = new List<Recommendation>();

        if (accountReservations.Any())
        {

            //Add recommendations for most reserved reservation type and most reserved employee
            var reservationType = accountReservations.GroupBy(x => x.ReservationType).OrderByDescending(t => t.Count()).FirstOrDefault().Key;
            var employeeId = accountReservations.GroupBy(x => x.EmployeeId).OrderByDescending(t => t.Count()).FirstOrDefault().Key;

            recommendations.Add(new Recommendation()
            {
                EmployeeId = employeeId,
                ReservationType = (ReservationType)reservationType
            });
        }
        else
        {
            var reservations = await _unitOfWork.Reservations.GetAll();

            for (int i = 0; i < 4; i++)
            {
                recommendations.Add(new Recommendation()
                {
                    EmployeeId = reservations.Where(x => x.ReservationType == i).GroupBy(x => x.EmployeeId).OrderByDescending(g => g.Count()).FirstOrDefault().Key,
                    ReservationType = (ReservationType)i
                });
            }
        }

        return recommendations;
    }
}

