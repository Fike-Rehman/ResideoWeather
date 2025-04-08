using Newtonsoft.Json;
using System.Text.Json;

namespace ResideoWeather.Model
{
    public class ResideoWeatherData
    {
        [JsonProperty("title")]
        public required string City { get; set; }

        [JsonProperty("consolidated_weather")]
        public List<ConsolidatedWeather>? TempData { get; set; }
    }

    public class ConsolidatedWeather
    {
        [JsonProperty("applicable_date")]
        public DateTime? ApplicableDate { get; set; }

        [JsonProperty("min_temp")]
        public double? MinTemp { get; set; }

        [JsonProperty("max_temp")]
        public double? MaxTemp { get; set; }
    }
}
