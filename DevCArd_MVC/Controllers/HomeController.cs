using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Mime;

namespace DevCard_MVC.Controllers
{
    public class HomeController : Controller
    {
        

        public HomeController()
        {
            
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact();
            return View(model);
        }

        //[HttpPost]
        //public JsonResult Contact(IFormCollection form)
        //{
        //    return Json(Ok());
        //}

        [HttpPost]
        public JsonResult Contact(Contact contact)
        {
            Console.WriteLine(contact.ToString());
            return Json(Ok());
        }

        public FileResult SampleFile()
        {
            //return File("file-place");
            var fileByte = System.IO.File.ReadAllBytes("wwwroot/test.txt");

            const string fileName = "testFile.txt";
            return File(fileByte, MediaTypeNames.Text.Plain, fileName);
        }

        public JsonResult SampleJson()
        {
            return Json(new { 
                Id=12, 
                name="matt liaarson", 
                grade="Master", 
                role="developer" ,
                website="abc.com"});
        }


        public RedirectResult SampleRedirect()
        {
            return Redirect("https://www.google.com");
        }

        public RedirectToActionResult SampleRedirectToAction()
        {
            return RedirectToAction("Contact", "Home");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
