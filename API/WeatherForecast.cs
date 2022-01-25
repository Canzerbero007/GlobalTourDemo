namespace API;

public class WeatherForecast
{
    private DateTime date;

    public DateTime GetDate()
    {
        return date;
    }

    public void SetDate(DateTime value) => date = value;

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string Summary { get; set; }
    public DateTime Date { get; internal set; }
}
