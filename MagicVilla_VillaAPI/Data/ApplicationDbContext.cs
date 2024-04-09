using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options) 
        {
            
        }
        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Details = "A Royal Villa",
                    ImageUrl = "",
                    Occupancy = 5,
                    Rate = 200,
                    Sqft = 100,
                    Amenity = "",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new Villa()
                {
                    Id = 2,
                    Name = "Success Villa",
                    Details = "A Success Villa",
                    ImageUrl = "",
                    Occupancy = 5,
                    Rate = 800,
                    Sqft = 100,
                    Amenity = "",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                });
        }
    }
}
