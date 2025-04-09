using ResideoWeather.Model;

namespace ResideoWeather
{
    public interface IRemoteDataImporter
    {
        /// <summary>
        /// Asynchronously fetches weather data from the provided remote sources (URLs) representing different cities.
        /// </summary>
        /// <param name="urls"></param>
        /// <returns></returns>
        Task<List<ResideoWeatherData>> GetWeatherDataAsync();
    }
}
