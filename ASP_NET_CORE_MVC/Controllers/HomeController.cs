using ASP_NET_CORE_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json;
using static System.Net.WebRequestMethods;

namespace ASP_NET_CORE_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            List<Post> posts = new List<Post>();
            string url = "https://jsonplaceholder.typicode.com/posts";
            var cliente = new HttpClient(); //clase cliente que permite enviar/consultar una ApiRest, funciona por el protocolo http
            var response = await cliente.GetAsync(url);//devuelve la tarea de operación asincrona, representando el objeto
            var body = await response.Content.ReadAsStringAsync();// devuelve el mensaje de la operación asincrona
            posts = JsonSerializer.Deserialize<List<Post>>(body);// devuelve un valor Json

            return View("Index", posts);
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
}