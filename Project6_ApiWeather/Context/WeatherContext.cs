using Microsoft.EntityFrameworkCore;
using Project6_ApiWeather.Entities;

namespace Project6_ApiWeather.Context
{
    public class WeatherContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ULUSOY;initial catalog=DB_6_Project20;integrated Security=true;TrustServerCertificate=True");     
        }
        public DbSet<City> Cities { get; set; }




    }
}
