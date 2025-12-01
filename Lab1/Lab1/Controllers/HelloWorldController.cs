using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Lab1.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //public string Index()
        //{
        //    return "This is my default action...";
        //}
        //
        //Get: /HelloWorld/Welcome/
        //Requires using System.Text.Encoding.Web;

        //public string Welcome(string name, int ID = 1)
        //{
        //    //return "This is the Welcome action method...";
        //    //return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        //    return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        //}

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello" + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
