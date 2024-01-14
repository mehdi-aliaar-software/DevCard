using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.ViewComponents
{
	public class ProjectsViewComponent:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var projects = new List<Project>
			{
				new Project(1,"Taxi Auto Drive", "درخواست تاکسی خودران برای سفرهای درون شهری","project-1.jpg" , "LiaarsonX"),
				new Project(2,"Zood Food", "درخواست غذای فوری برای محدوده شهر مشهد","project-2.jpg" , "Restaurants"),
				new Project(3,"Schools", "سیستم هوشمند  اداره مدارس کشور","project-3.jpg" , "Secretary"),
				new Project(4,"Space OX", "پروژه طراحی سفینه های فضایی ","project-4.jpg" , "NASA")
			};

			return View("_Projects", projects);
		}
	}
}
