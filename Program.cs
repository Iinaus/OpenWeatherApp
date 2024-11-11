using System.Text.Json;
using dotenv.net;

class Program
{
    static async Task Main(string[] args)
    {
        HttpClient client = new HttpClient();
        DotEnv.Load();
        string apiKey = Environment.GetEnvironmentVariable("API_KEY");
        string city = "Helsinki";
        string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric"; 
        var data = client.GetStreamAsync(url);
        var weather = JsonSerializer.Deserialize<Weather>(await data); 
        Console.WriteLine(weather.name);
        Console.WriteLine(weather.main.temp);
    }

}