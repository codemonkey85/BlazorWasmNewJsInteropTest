namespace BlazorWasmNewJsInteropTest.Pages;

public partial class FetchData
{
    private WeatherForecast[]? forecasts;

    protected override async Task OnInitializedAsync() =>
        forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
}
