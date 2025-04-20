using System;
using System.Collections.Generic;

namespace GYMDBMS.Models
{
    public partial class Workout
    {
        public string WorkoutId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}
