using System.Text.Json;
using dotenv.net;

class Program
{
    static async Task Main(string[] args)
    {
        try {
            Console.WriteLine("Syötä paikkakunta:");
            string city = Console.ReadLine();

            var weatherCity = await FetchData(city);

            printWeatherInfo(weatherCity); 
                                
        } catch (System.Exception e) {
            Console.WriteLine($"Virheen tyyppi: {e.GetType()}");
            Console.WriteLine($"Virheen viesti: {e.Message}");
        } 
    }

    static async Task<Weather> FetchData(string city)
    {
        HttpClient client = new HttpClient();
        DotEnv.Load();
        string apiKey = Environment.GetEnvironmentVariable("API_KEY");
        string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric"; 
        var data = client.GetStreamAsync(url);
        var weather = JsonSerializer.Deserialize<Weather>(await data); 
        return weather;
    }

    static void printWeatherInfo(Weather weather)
    {
        if (weather != null) {               
            string date = weather.convertDate();

            Console.WriteLine($"Tänään on {date} ja paikassa {weather.name} on seuraavanlainen sää:");
            Console.WriteLine($"Lämpötila {weather.main.temp} °C, tuntuu kuin {weather.main.feels_like} °C.");
            Console.WriteLine($"Päivän ylin lämpötila on {weather.main.temp_max} °C ja alin {weather.main.temp_min} °C.");
            Console.WriteLine($"Ilmankosteus {weather.main.humidity} %.");
        } else {
            Console.WriteLine($"Säätilatietoja ei saatavilla.");
        }
    }
}