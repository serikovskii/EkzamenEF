using System;
using System.Collections.Generic;

namespace EkzamenEF.Models
{
    public class City : Entity
    {
        public string CityName { get; set; }
        public ICollection<Street> Streets { get; set; }
        public Guid CountryId { get; set; }
        public bool Delete { get; set; }

        public City()
        {
            Delete = false;
        }
    }
}