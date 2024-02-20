
using HotelManager.EntityLayer.Concrete;
using HotelProjectNet.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HotelProjectNet.DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=Alper\\SQLEXPRESS;initial catalog=ApiDBData; integrated security = true;TrustServerCertificate=True");
        }


        public DbSet<Room> Rooms { get; set; }

        public DbSet<Service> Services { get; set; }

        public DbSet<Staff> Staffs { get; set; }

        public DbSet<Subscribe> Subscribes { get; set; }

        public DbSet<Testimonial> Testimonials { get; set; }



    }
}
