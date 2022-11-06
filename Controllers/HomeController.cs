using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DotNetDockerCats.Models;

namespace DotNetDockerCats.Controllers;

public class HomeController : Controller
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

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}