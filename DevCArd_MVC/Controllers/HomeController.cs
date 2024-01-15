using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Mime;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevCard_MVC.Controllers
{
    public class HomeController : Controller
    {

        private readonly List<Service> _services = new List<Service>
        {
            new Service(1, "نقره ای"),
            new Service(2, "طلایی"),
            new Service(3, "پلاتین"),
            new Service(4, "الماس")
        };

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact()
            {
                Services = new SelectList(_services, "Id","Name")
            };
            return View(model);
        }

        ////[HttpPost]
        ////public JsonResult Contact(IFormCollection form)
        ////{
        ////    return Json(Ok());
        ////}

        //[HttpPost]
        //public JsonResult Contact(Contact contact)
        //{
        //    Console.WriteLine(contact.ToString());
        //    return Json(Ok());
        //}


        [HttpPost]
        public IActionResult Contact(Contact contact)
        {

            contact.Services=new SelectList(_services, "Id","Name");    // for avoiding error on browser when returning to the page because of any validation=false!

            if (ModelState.IsValid==false)
            {
                //====  ViewData makes error for null in initial action. so we use ViewBag instead:
                //ViewData["error"] = "there is a problem with the data you entered. Try agian!";
                ViewBag.error = "there is a problem with the data you entered. Try agian!";

                return View(contact);
            }

            //return RedirectToAction("Index");

            ModelState.Clear();

            contact = new Contact
            {
                Services = new SelectList(_services, "Id",
                    "Name") // for avoiding error on browser when returning to the page even on validated data!
            };

            //====  ViewData makes error for null in initial action. so we use ViewBag instead:
            //ViewData["success"] = "your message submitted successfully. Thanks";
            ViewBag.success = "your message submitted successfully. Thanks";

            return View(contact);
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
