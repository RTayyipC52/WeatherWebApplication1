using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using WeatherWebApplication1.Models;

namespace WeatherWebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            HttpClient client = new HttpClient();

            var responseMessage = client.GetAsync("https://www.metaweather.com/api/location/44418/2013/4/27/").Result;
            List<WeatherForecast> weathers = null;
            if (responseMessage.StatusCode == System.Net.HttpStatusCode.OK)
            {
                weathers = JsonConvert.DeserializeObject<List<WeatherForecast>>(responseMessage.Content.ReadAsStringAsync().Result);
            }

            return View(weathers);
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
