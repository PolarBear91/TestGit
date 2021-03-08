using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitTestReact.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public string Discription { get; set; }
        public int IdCategory { get; set; }
    }
}
