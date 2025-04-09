using Newtonsoft.Json;
using ResideoWeather.Model;
using System.Xml;


namespace ResideoWeather
{
    public partial class ResideoWeather : Form
    {
        private readonly IRemoteDataImporter _remoteDataImporter;
        public ResideoWeather(IRemoteDataImporter remoteDataImporter)
        {
            InitializeComponent();

            _remoteDataImporter = remoteDataImporter ?? throw new ArgumentNullException(nameof(remoteDataImporter));
        }

        private void ResideoWeather_Load(object sender, EventArgs e)
        {

        }

        private async void btnGetWeather_Click(object sender, EventArgs e)
        {
            var weatherDatas = new List<ResideoWeatherData>();

            var remoteWeatherData = new List<string>
            {
                "https://s3.amazonaws.com/connectedsavings.com/coding/weather/401024.json",
                "https://s3.amazonaws.com/connectedsavings.com/coding/weather/746560.json",
                "https://s3.amazonaws.com/connectedsavings.com/coding/weather/77536.json" 
            };

            // import weather data from remote sources
            var cityWeatherData = await _remoteDataImporter.GetWeatherDataAsync(remoteWeatherData);

            // first transform the data into the shape that we need for our report
            var transformedCityWeatherData = cityWeatherData
                .Where(cwd => cwd?.TempData != null) // Ensure TempData is not null
                .SelectMany(cwd => cwd.TempData!)
                .Select(w => new
                {
                    w.ApplicableDate,
                    w.MinTemp,
                    w.MaxTemp,
                    City = cityWeatherData.FirstOrDefault(c => c.TempData != null && c.TempData.Contains(w))?.City
                })
                .ToList();

            // then filter out (we only need to get the cites with the lowest temp for each date)
            var filteredCityWeatherData = transformedCityWeatherData
                .GroupBy(w => w.ApplicableDate)
                .Select(g => g.OrderBy(w => w.MinTemp).FirstOrDefault()) // select the first min temp for each date if there is a tie
                .ToList();

            // before we get the json report, we need to fix the property names:

            var jsonReadyList = filteredCityWeatherData
                .Where(x => x!= null)
                .Select(fcwd => new
                {
                    applicable_date = fcwd!.ApplicableDate,
                    min_temp = fcwd.MinTemp,
                    max_temp = fcwd.MaxTemp,
                    title = fcwd.City
                })
                .ToList();

            var jsonReport = JsonConvert.SerializeObject(jsonReadyList, Newtonsoft.Json.Formatting.Indented);

            rtbJsonReport.Text = jsonReport;
        }
    }
}
