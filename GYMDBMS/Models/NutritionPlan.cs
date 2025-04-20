using System;
using System.Collections.Generic;

namespace GYMDBMS.Models
{
    public partial class NutritionPlan
    {
        public string PlanId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;

    }
}
