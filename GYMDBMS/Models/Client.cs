using System;
using System.Collections.Generic;

namespace GYMDBMS.Models
{
    public partial class Client
    {
        public string ClientId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string ContactNumer { get; set; } = null!;
        public string FitnessGoal { get; set; } = null!;
        public string TrainerId { get; set; } = null!;

        public Trainer Trainer { get; set; }

    }
}
