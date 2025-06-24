namespace Ml_dex_industrial_intership {

    
    
    public class Program
    {
        public static void Main(string[] args)
        {
            String dataPath = "../input/anime.csv";
            var Name = @"Fullmetal Alchemist: Brotherhood";
            var Genre = @"Action, Adventure, Drama, Fantasy, Magic, Military, Shounen";
            var Type = @"TV";
            var Episodes = @"64";
            var Members = @"793665";

            // Create single instance of sample data from first line of dataset for model input
            MLAnimeRatingPredictor.ModelInput sampleData = new MLAnimeRatingPredictor.ModelInput()
            {
                Name = Name,
                Genre = Genre,
                Type = Type,
                Episodes = Episodes,
                Members = Members,
            };


            Console.WriteLine("Использование модели для создания единого прогноза — сравнение фактического рейтинга с прогнозируемым рейтингом на основе выборочных данных...\n\n");


            Console.WriteLine($"Название: {Name}");
            Console.WriteLine($"Жанр: {Genre}");
            Console.WriteLine($"Тип: {Type}");
            Console.WriteLine($"Эпизоды: {Episodes}");
            Console.WriteLine($"Просмотры: {Members}");


            // Make a single prediction on the sample data and print results
            var predictionResult = MLAnimeRatingPredictor.Predict(sampleData);
            Console.WriteLine($"\n\nПредполагаемый рейтинг: {predictionResult.Score}\n\n");

            Console.WriteLine(" =============== Конец анализа ===============");
            Console.ReadKey();

        }
    }
}
