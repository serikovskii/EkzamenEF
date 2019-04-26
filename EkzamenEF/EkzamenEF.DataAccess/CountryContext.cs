namespace EkzamenEF.DataAccess
{
    using EkzamenEF.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CountryContext : DbContext
    {
        public CountryContext()
            : base("name=CountryContext")
        {
        }

        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Street> Streets { get; set; }
        public virtual DbSet<Deleted> Deleteds { get; set; }
        public virtual DbSet<Updated> Updateds { get; set; }
    }
}