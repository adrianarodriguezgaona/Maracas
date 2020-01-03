using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MaracasMusic.MVC.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()


        {
            //HttpClient httpClient = new HttpClient();

            //string baseUri = "https://localhost:44378/api/client/";

            //var client = new Client { Name = user.UserName, Email = user.Email, UserId = Guid.Parse(user.Id) };
            //HttpResponseMessage response = await httpClient.PostAsJsonAsync(baseUri, client);


            return View();
        }
    }
}