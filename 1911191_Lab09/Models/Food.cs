using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1911191_Lab09.Models
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public int FoodCategoryID { get; set; }
        public int Price { get; set; }
        public string Notes { get; set; }
        public Category Category { get; set; }
    }
}
