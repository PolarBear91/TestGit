using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitTestReact.Models
{

    // public string UrlImage { get; set; }

    public class Product
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public int IdCategory { get; set; }
    }
}
