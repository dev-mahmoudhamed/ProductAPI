using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Identity
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<AppUser>()
                .HasMany(u => u.Products)
                .WithOne(m => m.AppUser)
                .HasForeignKey(m => m.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Name = "Manager",
                    NormalizedName = "MANAGER"
                },
                new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Name = "Customer",
                    NormalizedName = "CUSTOMER"
                });



            builder.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = 1,
                    Name = "Cat_1",
                    Description = "catgeory descriptopn L1",
                    IsDeleted = false,
                },
                new Category
                {
                    CategoryId = 2,
                    Name = "Cat_2",
                    Description = "catgeory descriptopn L2",
                    IsDeleted = false,
                });

            for (int i = 1; i < 100; i++)
            {


                builder.Entity<Product>().HasData(
                new Product
                {
                    Id = i,
                    Name = "Product " + i,
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting" +
                    " industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s," +
                    " when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                    Price = i * 10,
                    IsDeleted = false,
                    CategoryId = 2,
                    UserId = "951d5cf7-c470-4504-ba7e-31bd07e43589"

                });
            }
            //*******************************************************************************
            builder.Entity<AppUser>().ToTable("Users");
            builder.Entity<IdentityRole>().ToTable("Roles");
            builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens");
            builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles");
            builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins");
            builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims");
            //*******************************************************************************

        }
    }
}
