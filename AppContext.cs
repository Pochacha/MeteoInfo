using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteoInfo
{
    internal class AppContext : DbContext
    {
        public DbSet<Record> WeatherData { get; set; } = null!;
        public Settings Settings { get; private set; }
        public AppContext(Settings settings)
        {
            Settings = settings;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"{Settings.Options[3].Trim()}");
        }
    }
}
