using System;
using System.ComponentModel.DataAnnotations;

namespace NycBdb.Common.Models
{
    public class Building
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

        public string Architect { get; set; }

        public string Description { get; set; }

        public string Neighborhood { get; set; }

        public BuildingType Type { get; set; }

        public DateTime Created { get; set; }

        public DateTime Modified { get; set; }
    }
}
