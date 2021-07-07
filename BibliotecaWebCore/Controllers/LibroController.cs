using BibliotecaWebCore.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace BibliotecaWebCore.Controllers
{
    public class LibroController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            //string Baseurl = "http://localhost:56984/";

            //List<LibroModel> lstAutor = new List<LibroModel>();
            //using (var client = new HttpClient())
            //{
            //    //Passing service base url
            //    client.BaseAddress = new Uri(Baseurl);
            //    client.DefaultRequestHeaders.Clear();
            //    //Define request data format
            //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //    //Sending request to find web api REST service resource GetAllEmployees using HttpClient
            //    HttpResponseMessage Res = await client.GetAsync("/Autor/GetLibros");
            //    //Checking the response is successful or not which is sent using HttpClient
            //    if (Res.IsSuccessStatusCode)
            //    {
            //        //Storing the response details recieved from web api
            //        var Response = Res.Content.ReadAsStringAsync().Result;
            //        //Deserializing the response recieved from web api and storing into the Employee list
            //        lstAutor = JsonConvert.DeserializeObject<List<LibroModel>>(Response);
            //    }
            //    //returning the employee list to view
            //    return View(lstAutor);

            return View();
            

        }
    }
}
