using System;
using System.Collections.Generic;
using System.Text;

namespace BethanysPieShopMobile.Model
{
    public class Pie
    {
        public string PieName { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public bool InStock { get; set; }
    }
}
