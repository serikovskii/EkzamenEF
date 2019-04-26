using EkzamenEF.DataAccess;
using EkzamenEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkzamenEF
{
    class Program
    {
        static void Main(string[] args)
        {

            string countryView;
            countryView = Console.ReadLine();

            using (var context = new CountryContext())
            {
                var streetsOne = new List<Street>
                {
                    new Street
                    {
                        StreetName = "Baraeva"
                    },
                    new Street
                    {
                        StreetName = "Moldagulova"
                    },
                    new Street
                    {
                        StreetName = "Pobeda"
                    }

                };
                var streetsTwo = new List<Street>
                {
                    new Street
                    {
                        StreetName = "Furmanova"
                    },
                    new Street
                    {
                        StreetName = "Navoi"
                    },
                    new Street
                    {
                        StreetName = "Tole Bi"
                    }

                };
                var cities = new List<City>
                {
                    new City
                    {
                        CityName = "Astana", Streets = streetsOne
                    },
                    new City
                    {
                        CityName = "Almaty", Streets = streetsTwo
                    }
                };
                var country = new Country
                {
                    CountryName = "Kazakhstan", Citys = cities
                };

                context.Streets.AddRange(streetsOne);
                context.Streets.AddRange(streetsTwo);

                context.Cities.AddRange(cities);
                context.Countries.Add(country);

                context.SaveChanges();

                var resultCountry = context.Countries.Where(countryRes => countryRes.CountryName.Contains(countryView)).FirstOrDefault();
                var resultCity = context.Cities.Where(city => city.CountryId == resultCountry.Id).FirstOrDefault();
                var resultStreet = context.Streets.Where(street => street.CityId == resultCity.Id).ToList();

                foreach(var street in resultStreet)
                {
                    Console.WriteLine(street.StreetName);
                }



                var deleted = new Deleted
                {
                    DeletedObjectId = resultStreet.ToList()[1].Id
                };
                context.Streets.ToList()[1].Delete = true;
                
                var updated = new Updated
                {
                    UpdatedObjectId = resultStreet.ToList()[2].Id,
                    OldNameObject = resultStreet.ToList()[2].StreetName
                };
                context.Streets.ToList()[2].StreetName = "Abay";
                context.SaveChanges();
            }
        }
    }
}
