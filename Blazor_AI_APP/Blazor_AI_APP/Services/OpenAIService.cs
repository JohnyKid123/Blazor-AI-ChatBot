using System.Net.Http;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Configuration;

public class OpenAIService
{
    private readonly HttpClient _http;
    private readonly string _apiKey;

    public OpenAIService(IConfiguration config)
    {
        _http = new HttpClient();
        _apiKey = config["OpenAI:ApiKey"];

        Console.WriteLine("🔐 API KEY LOADED: " + (_apiKey?.Substring(0, 5) ?? "NOT FOUND"));
    }

    public async Task<string> AskAsync(string prompt)
    {
        Console.WriteLine("🔔 AskAsync Called!");
        await Task.Delay(500); // симулира изчакване
        return "🔁 Това е тестов отговор.";
    }

}
