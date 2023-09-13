using eGym.BLL.Models;
using eGym.BLL.Models.Enums;
using eGym.DAL;
using eGym.Domain;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers;
namespace eGym.BLL.Implementation;

public class RecommendationService : IRecommendationService
{
    private readonly IUnitOfWork _unitOfWork;

    public RecommendationService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    private const double V = 0.00001;
    static object isLocked = new object();
    static MLContext mlContext = null;
    static ITransformer model = null;

    public async Task<List<Recommendation>> Get(int accountId)
    {
        List<Reservation> allReservations;

        allReservations = (await _unitOfWork.Reservations.GetAll()).ToList();
        lock (isLocked)
        {
            if (mlContext == null)
            {
                mlContext = new MLContext();
                var data = new List<RecommendationEntry>();
                var traindata = mlContext.Data.LoadFromEnumerable(data);
                var options = new MatrixFactorizationTrainer.Options()
                {
                    MatrixColumnIndexColumnName = nameof(RecommendationEntry.RecommendationID),
                    MatrixRowIndexColumnName = nameof(RecommendationEntry.CoPurchaseRecommendationID),
                    LabelColumnName = "Label",
                    LossFunction = MatrixFactorizationTrainer.LossFunctionType.SquareLossOneClass,
                    Alpha = 0.01,
                    Lambda = 0.025,
                    NumberOfIterations = 100,
                    C = V
                };

                var trainer = mlContext.Recommendation().Trainers.MatrixFactorization(options);
                model = trainer.Fit(traindata);
            }
        }

        var predictionResult = new List<Tuple<Reservation, float>>();

        foreach (var reservation in allReservations)
        {
            var predictionEngine = mlContext.Model.CreatePredictionEngine<RecommendationEntry, CoPurchase_prediction>(model);
            var prediction = predictionEngine.Predict(new RecommendationEntry()
            {
                RecommendationID = (uint)accountId,
                CoPurchaseRecommendationID = (uint)reservation.ReservationId
            });

            predictionResult.Add(new Tuple<Reservation, float>(reservation, prediction.Score));
        }

        var finalResult = predictionResult.OrderByDescending(x => x.Item2).Select(x => x.Item1).Take(3).ToList();

        var recommendations = finalResult.Select(reservation => new Recommendation
        {
            EmployeeId = reservation.EmployeeId, 
            ReservationType = (ReservationType)reservation.ReservationType 
        }).ToList();

        return recommendations;
    }

    public class RecommendationEntry
    {
        [KeyType(count: 5000)]
        public uint RecommendationID { get; set; }

        [KeyType(count: 5000)]
        public uint CoPurchaseRecommendationID { get; set; }
        public float Label { get; set; }
    }

    public class CoPurchase_prediction
    {
        public float Score { get; set; }
    }
}

