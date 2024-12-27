using Microsoft.ML;
using Microsoft.ML.Data;

namespace LINQMachineLearning
{
    class Program
    {
        public class HouseData
        {
            public float Size { get; set; }
            public float Price { get; set; }
        }

        public class Prediction
        {
            [ColumnName("Score")]
            public float Price { get; set; }
        }

        static void Main(string[] args)
        {
            // ML.NET setup for prediction
            var mlContext = new MLContext();
            var data = new[]
            {
                new HouseData { Size = 1.1F, Price = 1.2F },
                new HouseData { Size = 1.9F, Price = 2.3F }
            };

            // Train model
            var trainData = mlContext.Data.LoadFromEnumerable(data);
            var pipeline = mlContext.Transforms.Concatenate("Features", new[] { "Size" })
                .Append(mlContext.Regression.Trainers.Sdca());
            var model = pipeline.Fit(trainData);

            // Predict using LINQ
            var predictionEngine = mlContext.Model.CreatePredictionEngine<HouseData, Prediction>(model);
            var house = new HouseData { Size = 2.0F };
            var pricePrediction = predictionEngine.Predict(house);

            Console.WriteLine($"Predicted Price: {pricePrediction.Price}");
        }
    }
}