public class Weather
{
    public string name { get; set; }
    public int dt { get; set; }
    public Main main { get; set;}

    public string convertDate()
    {
        DateTime dateTime = DateTimeOffset.FromUnixTimeSeconds(dt).UtcDateTime;
        string shortDate = dateTime.ToString("d");
        return shortDate;
    }

}

public class Main
{
    public double temp { get; set; }
    public double feels_like { get; set; }
    public double temp_min { get; set; }
    public double temp_max { get; set; }
    public int humidity { get; set; }
}