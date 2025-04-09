using Newtonsoft.Json;
using ResideoWeather.Model;

namespace ResideoWeather
{
    public class ResideoWeatherReportFormatter : IResideoWeatherReportFormatter
    {
        public string Format(List<ResideoWeatherData> cityWeatherData)
        {
            // 1. Transform
            // first format the incoming data into the shape that we need for our report
            var formattedCityWeatherData = cityWeatherData
                .Where(cwd => cwd?.TempData != null) // Ensure TempData is not null
                .SelectMany(cwd => cwd.TempData!)    // flatten all available weather data
                .Select(w => new                     // transform the data into a new shape that we need for the report       
                {
                    w.ApplicableDate,
                    w.MinTemp,
                    w.MaxTemp,
                    cityWeatherData.FirstOrDefault(c => c.TempData != null && c.TempData.Contains(w))?.City
                })
                .ToList();

            // 2. Filter
            // then filter out (we only need to get the city with the lowest temp for each date)
            var filteredCityWeatherData = formattedCityWeatherData
                .GroupBy(w => w.ApplicableDate)
                .Select(g => g.OrderBy(w => w.MinTemp).FirstOrDefault()) // select the first min temp for each date if there is a tie
                .ToList();

            // 3. Format
            // we are required to use specific property names in our output report. Let's fix that:
            var jsonList = filteredCityWeatherData
                .Where(x => x != null)
                .Select(fcwd => new
                {
                    applicable_date = fcwd!.ApplicableDate,
                    min_temp = fcwd.MinTemp,
                    max_temp = fcwd.MaxTemp,
                    title = fcwd.City
                })
                .ToList();

            return JsonConvert.SerializeObject(jsonList, Formatting.Indented);
        }
    }
}
