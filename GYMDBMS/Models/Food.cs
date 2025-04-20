using System;
using System.Collections.Generic;

namespace GYMDBMS.Models
{
    public partial class Food
    {
        public string FoodId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Calories { get; set; } = null!;
        public string Protien { get; set; } = null!;
        public double Carbohydrates { get; set; }
        public double Fat { get; set; }
        
    }
}
