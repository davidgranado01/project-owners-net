using System;
using System.Collections.Generic;

namespace project_owners_net.Models
{
    public partial class Owner
    {
        public Owner()
        {
            Vehicles = new HashSet<Vehicle>();
        }

        public int Id { get; set; }
        public string FistName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string DriverLicense { get; set; } = null!;

        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
