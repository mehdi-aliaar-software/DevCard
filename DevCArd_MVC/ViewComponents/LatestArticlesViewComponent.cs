using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.ViewComponents
{
    public class LatestArticlesViewComponent:ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            var articles = new List<Article>
            {
                new Article(1,"Teaching AspNet", "this is one of the best courses you must learn.","blog-post-thumb-card-1.jpg" ),
                new Article(2,"Teaching Git", "this is the urgent courses you must learn.","blog-post-thumb-card-2.jpg" ),
                new Article(3,"Teaching AI", "what you need to acquire to go top.","blog-post-thumb-card-3.jpg" ),
                new Article(4,"Teaching Data Analysis", "this is one of the best courses you must learn.","blog-post-thumb-card-4.jpg" )
            };


            return View("_LatestArticles", articles);
        }
    }
}
