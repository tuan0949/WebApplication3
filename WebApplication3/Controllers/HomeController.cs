using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication3.Data;
using WebApplication3.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
       // private readonly ILogger<HomeController> _logger;
        private MyBlogContext myBlogContext;

        /*   public HomeController(ILogger<HomeController> logger)
           {
               _logger = logger;
           }*/

        public HomeController(MyBlogContext logger)
        {
            myBlogContext = logger;
        }

        public IActionResult Index()
        {
          
            return View();
        }

        public IActionResult Privacy()
        {
            /* using (var ctx = new MyBlogContext())
             {
                 string id = "haha";
                 Blog blog = new Blog(id);
                 ctx.Blogs.Add(blog);
                 ctx.SaveChanges();
             }*/
            var x = myBlogContext.Blogs.ToList();
            string id = "d104b38e-8bd6-4daa-b8a2-d78277881701";
            Blog blog = new Blog(id);
            myBlogContext.Blogs.Add(blog);
            myBlogContext.SaveChanges();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
