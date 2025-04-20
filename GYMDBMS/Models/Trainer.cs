using System;
using System.Collections.Generic;

namespace GYMDBMS.Models
{
    public partial class Trainer
    {
        public Trainer()
        {
            Clients = new HashSet<Client>();
        }

        public string TrainerId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string ContactNumber { get; set; } = null!;
        public string Specialty { get; set; } = null!;
       

        public virtual ICollection<Client> Clients { get; set; }
    }
}