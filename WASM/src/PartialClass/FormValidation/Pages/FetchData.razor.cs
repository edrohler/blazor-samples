namespace FormValidation
{
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
using System.Net.Http;

    public partial class FetchDataBase : ComponentBase
    {
        protected WeatherForecast[] forecasts;

        public class WeatherForecast
        {
            public DateTime Date { get; set; }

            public int TemperatureC { get; set; }

            public string Summary { get; set; }

            public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
        }      
    }
}