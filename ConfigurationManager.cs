using Microsoft.Extensions.Configuration;

namespace ResideoWeather
{
    public static class ConfigurationManager
    {
        public static List<string> ImportDataUrls { get; private set; } = null!;

        public static void Initialize()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var urls = config.GetSection("ImportDataUrls").Get<List<string>>();

            if (urls == null || urls.Count == 0)
            {
                throw new Exception("No import data URLs found in configuration.");
            }

            ImportDataUrls = urls;
        }
    }
}
