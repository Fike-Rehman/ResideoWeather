namespace ResideoWeather
{
    public partial class ResideoWeather : Form
    {
        private readonly IRemoteDataImporter _remoteDataImporter;
        private readonly IResideoWeatherReportFormatter _resideoWeatherReportFormatter;

        public ResideoWeather(
            IRemoteDataImporter remoteDataImporter, 
            IResideoWeatherReportFormatter resideoWeatherReportFormatter)
        {
            InitializeComponent();

            _remoteDataImporter = remoteDataImporter ?? throw new ArgumentNullException(nameof(remoteDataImporter));
            _resideoWeatherReportFormatter = resideoWeatherReportFormatter ?? throw new ArgumentNullException(nameof(resideoWeatherReportFormatter));
        }

        private void ResideoWeather_Load(object sender, EventArgs e)
        {

        }

        private async void btnGetWeather_Click(object sender, EventArgs e)
        {
            // import weather data from remote sources
            var cityWeatherData = await _remoteDataImporter.GetWeatherDataAsync();

            // format the data into a report
            var jsonReport = _resideoWeatherReportFormatter.Format(cityWeatherData);

            rtbJsonReport.Text = jsonReport;
        }
    }
}
