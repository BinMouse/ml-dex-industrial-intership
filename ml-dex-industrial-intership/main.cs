using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Transforms;
using Ml_dex_industrial_intership;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using static Ml_dex_industrial_intership.MLAnimeRatingPredictor;

namespace Ml_dex_industrial_intership
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var MLNetModelPath = @"F:\Projects\ML\ml-dex-industrial-practice\ml-dex-industrial-intership\ml-dex-industrial-intership\MLAnimeRatingPredictor.mlnet";
            //var MLNetModelPath = Path.GetFullPath("MLAnimeRatingPredictor.mlnet");
            var inputDataFilePath = @"F:\Projects\ML\ml-dex-industrial-practice\ml-dex-industrial-intership\input\anime.csv";
            // Training the ML.NET Anime Rating Predictor
            Console.WriteLine("Starting ML.NET Anime Rating Predictor Training...");
            MLAnimeRatingPredictor.Train(
                outputModelPath: MLNetModelPath,
                inputDataFilePath: inputDataFilePath,
                separatorChar: ',',
                hasHeader: true,
                allowQuoting: true
            );
            Console.WriteLine(File.Exists(MLNetModelPath));

            var Sample = new ModelInput() {
                Name = "Kimi no Naфцвфцвфц wa.",
                Genre = "",
                Type = "Movie",
                Episodes = "12",
                Rating = 9.37f,
                Members = 793665,
            };

            Console.WriteLine($"Anime:\n Name={Sample.Name}\n Genre={Sample.Genre}\n Type={Sample.Type}\n Episodes={Sample.Episodes}\n Members={Sample.Members}\n Rating={Sample.Rating}\n");
            var prediction = MLAnimeRatingPredictor.Predict(Sample);
            Console.WriteLine($"Predicted rating: {prediction.Score}");
        }
    }
}
