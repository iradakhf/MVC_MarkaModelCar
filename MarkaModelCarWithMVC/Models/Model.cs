using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarkaModelCarWithMVC.Models
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Year { get; set; }
        public List<Car> Cars { get; set; }
        public int MarkaId { get; set; }
    }
}
