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
            rtbJsonViewer.ReadOnly = true;
            rtbJsonViewer.Text = string.Empty;

            lblAppTitle.Text = "Resideo Weather Report 🌞 ☁️ 🌧️ ❄️🌩️";
        }

        private async void btnGetWeather_Click(object sender, EventArgs e)
        {
            try
            {
                // import weather data from remote sources
                var cityWeatherData = await _remoteDataImporter.GetWeatherDataAsync();

                // format the data into a report
                var jsonReport = _resideoWeatherReportFormatter.Format(cityWeatherData);

                rtbJsonViewer.Text = jsonReport;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
