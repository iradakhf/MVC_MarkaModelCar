using MarkaModelCarWithMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarkaModelCarWithMVC.ViewModel.Home;

namespace MarkaModelCarWithMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Marka> _markas;
        private readonly List<Model> _models;
        private readonly List<Car> _cars;
        public HomeController()
        {
            _markas = new List<Marka>
            {
                new Marka
                {
                    Id= 1,
                    Name = "Acura"
                },
                new Marka
                {
                    Id= 2,
                    Name = "Abarth"
                },
                new Marka
                {
                    Id= 3,
                    Name = "Infiniti"
                },
                new Marka
                {
                    Id= 4,
                    Name = "Asia"
                }
            };
            _models = new List<Model>
            {
                new Model
                {
                    Id = 1,
                    Name = "H99",
                    Year = "2001"
                },
                new Model
                {
                    Id = 2,
                    Name = "HS9",
                    Year = "2011"
                },
                new Model
                {
                    Id = 3,
                    Name = "Alsvin V5",
                    Year = "2006"
                },
                new Model
                {
                    Id = 4,
                    Name = "Easter",
                    Year = "2007"
                }
            };
            _cars = new List<Car>
            {
                new Car
                {
                    Id = 1,
                    Name = "My First Car",
                },
                new Car
                {
                    Id = 2,
                    Name = "My Second Car",
                },
                new Car
                {
                    Id = 3,
                    Name = "My Third Car",
                },
                new Car
                {
                    Id = 4,
                    Name = "My Fourth Car",
                }
            };
        }
        public IActionResult Index()
        {
            
            Blog blog = new Blog
            {
                Name = "Model",
                Title = "how to call model",
                Content = "video may have been displayed here"
            };
            HomeVM homeVM = new HomeVM
            {
                Markas = _markas,
                Models = _models

            };
            return View(homeVM);
        }
        
        public IActionResult Models(int? id)
        {
            Model model = _models.Find(mod => mod.Id == id);
            return View(model);

        }
        public IActionResult Cars(int? id)
        {
            Car car = _cars.Find(car => car.Id == id);
            return View(car);
        }
    }
}
