    using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Vargas_TallerConexionIA.Interfaces;
using Vargas_TallerConexionIA.Models;
using Vargas_TallerConexionIA.Repositories;

namespace Vargas_TallerConexionIA.Controllers;

public class HomeController : Controller
{
    private IChatbotService _chatbotService;

    public HomeController()
    {
        _chatbotService = new GeminiRepository();
    }

    public async Task<IActionResult> Index()
    {
        string response = await _chatbotService.GetChatbotResponseAsync("Dame un resumen de 100 palabras de la pelicula spiderman no way home");
        ViewBag.chatbotAnswer = response;
        return View();
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
