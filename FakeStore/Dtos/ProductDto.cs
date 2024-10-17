using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeStore.Dtos
{
    public class ProductDto
    {
        public int id { get; set; } 
        public string title { get; set; }
        public decimal price { get; set; }
        public string description { get; set; }
        public string category { get; set; } 
        public string image { get; set; }
     

        
        public Rating rating { get; set; }

        
        public class Rating
        {
            public double rate { get; set; } 
            public int count { get; set; } 
        }
    }
}
