using Newtonsoft.Json;
using ResideoWeather.Model;

namespace ResideoWeather
{
    public class RemoteDataImporter : IRemoteDataImporter
    {
        public async Task<List<ResideoWeatherData>> GetWeatherDataAsync()
        {
            var weatherDatas = new List<ResideoWeatherData>();

            var remoteWeatherData = new List<string>
            {
                "https://s3.amazonaws.com/connectedsavings.com/coding/weather/401024.json",
                "https://s3.amazonaws.com/connectedsavings.com/coding/weather/746560.json",
                "https://s3.amazonaws.com/connectedsavings.com/coding/weather/77536.json"
            };

            var cityWeathers = new List<ResideoWeatherData>();

            using (var client = new HttpClient())
            {
                try
                {
                    foreach (var url in remoteWeatherData)
                    {
                        var json = await client.GetStringAsync(url);
                        var weatherData = JsonConvert.DeserializeObject<ResideoWeatherData>(json);

                        if (weatherData != null)
                        {
                            cityWeathers.Add(weatherData);
                        }
                    }
                }
                catch (HttpRequestException ex)
                {
                    throw new Exception($"Error fetching data from remote source: {ex.Message}", ex);
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error parsing city weather data: {ex.Message}", ex);
                }
            }

            return cityWeathers;
        }
    }
}
