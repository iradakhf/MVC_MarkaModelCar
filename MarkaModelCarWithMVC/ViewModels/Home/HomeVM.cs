using MarkaModelCarWithMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarkaModelCarWithMVC.ViewModel.Home
{
    public class HomeVM
    {
        public List<Marka> Markas { get; set; }
        public List<Model> Models { get; set; }
    }
}
