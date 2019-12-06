namespace TelerikBlazorApp.CodeBehindSample.Client.Pages
{
    using Microsoft.AspNetCore.Components;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using TelerikBlazorApp.CodeBehindSample.Shared;
    using System.Net.Http;

    public class FetchDataBase : ComponentBase
    {
        protected WeatherForecast[] forecasts;

        protected override async Task OnInitializedAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                forecasts = await client.GetJsonAsync<WeatherForecast[]>("WeatherForecast");
            }
        }
    }
}
