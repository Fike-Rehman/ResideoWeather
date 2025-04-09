using ResideoWeather.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResideoWeather
{
    public interface IResideoWeatherReportFormatter
    {
        public string Format(List<ResideoWeatherData> cityWeatherData);
    }
}
