using ResideoWeather.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResideoWeather
{
    public interface IRemoteDataImporter
    {
        /// <summary>
        /// Asynchronously fetches weather data from the provided remote sources (URLs) representing different cities.
        /// </summary>
        /// <param name="urls"></param>
        /// <returns></returns>
        Task<List<ResideoWeatherData>> GetWeatherDataAsync(List<string> urls);
    }
}
