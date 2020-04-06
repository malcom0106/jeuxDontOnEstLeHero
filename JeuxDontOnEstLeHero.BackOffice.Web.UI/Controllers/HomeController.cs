using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using JeuxDontOnEstLeHero.BackOffice.Web.UI.Models;
using RestSharp;
using RestSharp.Authenticators;
using Newtonsoft.Json.Linq;

namespace JeuxDontOnEstLeHero.BackOffice.Web.UI.Controllers
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

            var client = new RestClient("https://covid-19-coronavirus-statistics.p.rapidapi.com/v1/stats?country=France");
            //client.Authenticator = new HttpBasicAuthenticator("username", "password");
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-host", "covid-19-coronavirus-statistics.p.rapidapi.com");
            request.AddHeader("x-rapidapi-key", "0326288ba9msh21286c3615c5e04p1021aejsn8d95c1cbc636");
            IRestResponse response = client.Execute(request);

            string details = (JObject.Parse(response.Content)["data"]["covid19Stats"]).ToString();
            ViewBag.DataJson = details;


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
}
