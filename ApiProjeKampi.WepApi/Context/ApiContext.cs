using ApiProjeKampi.WepApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiProjeKampi.WepApi.Context
{
    public class ApiContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-EPMBJ8I\\SQLEXPRESS;initial catalog=ApiYummuyDb;integrated security=true;");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Chef> Chefs { get; set; }
        public DbSet<Contact> Contacs { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Rezarvation> Rezarvations { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Testimonial>  Testimonials { get; set; }

    }
}
