using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkzamenEF.Models
{
    public class Country : Entity
    {
        public string CountryName { get; set; }
        public ICollection<City> Citys { get; set; }
        public bool Delete { get; set; }

        public Country()
        {
            Delete = false;
        }
    }
}
