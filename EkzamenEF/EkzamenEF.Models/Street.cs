using System;

namespace EkzamenEF.Models
{
    public class Street : Entity
    {
        public string StreetName { get; set; }
        public Guid CityId { get; set; }
        public bool Delete { get; set; }

        public Street()
        {
            Delete = false;
        }
    }
}