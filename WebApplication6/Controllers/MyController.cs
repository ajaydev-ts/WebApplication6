using Microsoft.AspNetCore.Mvc;
using System.Data;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class MyController : Controller
    {
        public IActionResult Startuppage()
        {
            return View();
        }
        public IActionResult Indexsecond()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Indexsecond(int num,int num2)

        {
           ViewData["result"] = num + num2;
            return View();
        }
        public IActionResult thirdpage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult thirdpage(Dataclass dc)
        {
            dc.result = dc.num + dc.num2;
            return View();
        }
        public IActionResult fourthpage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult fourthpage(Employee em)
        {
            HttpClient client = new HttpClient();
            client.PostAsJsonAsync("https://localhost:7088/api/Values/postallEmployee", em);
            return View();
        }

    }
}
