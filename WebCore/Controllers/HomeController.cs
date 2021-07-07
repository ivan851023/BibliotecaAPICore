using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using WebCore.Models;

namespace WebCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //public async Task<IActionResult> Index()
        //{
        //    string Baseurl = "http://localhost:56984/";

        //    List<AutorModel> lstAutor = new List<AutorModel>();
        //    using (var client = new HttpClient())
        //    {
        //        //Passing service base url
        //        client.BaseAddress = new Uri(Baseurl);
        //        client.DefaultRequestHeaders.Clear();
        //        //Define request data format
        //        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //        //Sending request to find web api REST service resource GetAllEmployees using HttpClient
        //        HttpResponseMessage Res = await client.GetAsync("Autor");
        //        //Checking the response is successful or not which is sent using HttpClient
        //        if (Res.IsSuccessStatusCode)
        //        {
        //            //Storing the response details recieved from web api
        //            var Response = Res.Content.ReadAsStringAsync().Result;
        //            //Deserializing the response recieved from web api and storing into the Employee list
        //            lstAutor = JsonConvert.DeserializeObject<List<AutorModel>>(Response);
        //        }
        //        //returning the employee list to view
        //        return View(lstAutor);
        //    }
        //}


        public ActionResult Index()
        {
            IEnumerable<AutorModel> students = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:56984/");
                //HTTP GET
                var responseTask = client.GetAsync("Autor");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<AutorModel>>();
                    readTask.Wait();

                    students = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    students = Enumerable.Empty<AutorModel>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(students);
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
