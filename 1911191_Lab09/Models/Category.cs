using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1911191_Lab09.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CatType Type { get; set; }
    }
    public enum CatType { Drink, Food }
}
