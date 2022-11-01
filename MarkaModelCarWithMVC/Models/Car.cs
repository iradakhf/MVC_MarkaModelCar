using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarkaModelCarWithMVC.Models
{
    public class Car
    {
        public int Id { get; set; }
        public int Price  { get; set; }
        public string Name { get; set; }
        public int ModelId { get; set; }
    }
}
