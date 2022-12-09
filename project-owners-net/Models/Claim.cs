using System;
using System.Collections.Generic;

namespace project_owners_net.Models
{
    public partial class Claim
    {
        public int Id { get; set; }
        public string Description { get; set; } = null!;
        public string Status { get; set; } = null!;
        public string Date { get; set; } = null!;
        public int VehicleId { get; set; }

        public virtual Vehicle Vehicle { get; set; } = null!;
    }
}
