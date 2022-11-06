using DotNetDockerCats.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetDockerCats.Controllers;

public class CatGeneratorController : Controller
{
    public async Task<IActionResult> Index()
    {
        const string uri = "https://api.thecatapi.com/v1/images/search";

        var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

        var client = new HttpClient();
        var response = await client.SendAsync(httpRequestMessage);

        response.EnsureSuccessStatusCode();

        var json = await response.Content.ReadFromJsonAsync<List<CatImageViewModel>>();

        return View(json.FirstOrDefault());
    }
}