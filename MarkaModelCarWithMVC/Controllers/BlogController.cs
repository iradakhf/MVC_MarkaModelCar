using MarkaModelCarWithMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarkaModelCarWithMVC.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            Blog blog = new Blog
            {
                Name = "Model",
                Title = "how to call model",
                Content = "video may have been displayed here"
            };
            return View(blog);
        }
    }
}
