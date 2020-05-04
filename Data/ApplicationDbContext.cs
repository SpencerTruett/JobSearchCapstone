using System;
using System.Collections.Generic;
using System.Text;
using JobSearch.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JobSearch.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Applicant> Applicant { get; set; }
        public DbSet<ApplicantJob> ApplicantJob { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<EmploymentType> EmploymentType { get; set; }
        public DbSet<Job> Job { get; set; }
        public DbSet<Location> Location { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            ApplicationUser user = new ApplicationUser
            {
                FirstName = "Admina",
                LastName = "Straytor",
                UserName = "admin@admin.com",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                Id = "00000000-ffff-ffff-ffff-ffffffffffff"
            };
            var passwordHash = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = passwordHash.HashPassword(user, "Admin8*");
            modelBuilder.Entity<ApplicationUser>().HasData(user);

            modelBuilder.Entity<Location>().HasData(
                new Location()
                {
                    Id = 1,
                    Name = "Alabama",
                },
                new Location()
                {
                    Id = 2,
                    Name = "Alaska",
                },
                new Location()
                {
                    Id = 3,
                    Name = "Arizona",
                },
                new Location()
                {
                    Id = 4,
                    Name = "Arkansas",
                },
                new Location()
                {
                    Id = 5,
                    Name = "California",
                },
                new Location()
                {
                    Id = 6,
                    Name = "Colorado",
                },
                new Location()
                {
                    Id = 7,
                    Name = "Connecticut",
                },
                new Location()
                {
                    Id = 8,
                    Name = "Delaware",
                },
                new Location()
                {
                    Id = 9,
                    Name = "Florida",
                },
                new Location()
                {
                    Id = 10,
                    Name = "Georgia",
                },
                new Location()
                {
                    Id = 11,
                    Name = "Hawaii",
                },
                new Location()
                {
                    Id = 12,
                    Name = "Idaho",
                },
                new Location()
                {
                    Id = 13,
                    Name = "Illinois",
                },
                new Location()
                {
                    Id = 14,
                    Name = "Indiana",
                },
                new Location()
                {
                    Id = 15,
                    Name = "Iowa",
                },
                new Location()
                {
                    Id = 16,
                    Name = "Kansas",
                },
                new Location()
                {
                    Id = 17,
                    Name = "Kentucky",
                },
                new Location()
                {
                    Id = 18,
                    Name = "Louisiana",
                },
                new Location()
                {
                    Id = 19,
                    Name = "Maine",
                },
                new Location()
                {
                    Id = 20,
                    Name = "Maryland",
                },
                new Location()
                {
                    Id = 21,
                    Name = "Massachusetts",
                },
                new Location()
                {
                    Id = 22,
                    Name = "Michigan",
                },
                new Location()
                {
                    Id = 23,
                    Name = "Minnesota",
                },
                new Location()
                {
                    Id = 24,
                    Name = "Mississippi",
                },
                new Location()
                {
                    Id = 25,
                    Name = "Missouri",
                },
                new Location()
                {
                    Id = 26,
                    Name = "Montana",
                },
                new Location()
                {
                    Id = 27,
                    Name = "Nebraska",
                },
                new Location()
                {
                    Id = 28,
                    Name = "Nevada",
                },
                new Location()
                {
                    Id = 29,
                    Name = "New Hampshire",
                },
                new Location()
                {
                    Id = 30,
                    Name = "New Jersey",
                },
                new Location()
                {
                    Id = 31,
                    Name = "New Mexico",
                },
                new Location()
                {
                    Id = 32,
                    Name = "New York",
                },
                new Location()
                {
                    Id = 33,
                    Name = "North Carolina",
                },
                new Location()
                {
                    Id = 34,
                    Name = "North Dakota",
                },
                new Location()
                {
                    Id = 35,
                    Name = "Ohio",
                },
                new Location()
                {
                    Id = 36,
                    Name = "Oklahoma",
                },
                new Location()
                {
                    Id = 37,
                    Name = "Oregon",
                },
                new Location()
                {
                    Id = 38,
                    Name = "Pennsylvania",
                },
                new Location()
                {
                    Id = 39,
                    Name = "Rhode Island",
                },
                new Location()
                {
                    Id = 40,
                    Name = "South Carolina",
                },
                new Location()
                {
                    Id = 41,
                    Name = "South Dakota",
                },
                new Location()
                {
                    Id = 42,
                    Name = "Tennessee",
                },
                new Location()
                {
                    Id = 43,
                    Name = "Texas",
                },
                new Location()
                {
                    Id = 44,
                    Name = "Utah",
                },
                new Location()
                {
                    Id = 45,
                    Name = "Vermont",
                },
                new Location()
                {
                    Id = 46,
                    Name = "Virginia",
                },
                new Location()
                {
                    Id = 47,
                    Name = "Washington",
                },
                new Location()
                {
                    Id = 48,
                    Name = "West Virginia",
                },
                new Location()
                {
                    Id = 49,
                    Name = "Wisconsin",
                },
                new Location()
                {
                    Id = 50,
                    Name = "Wyoming",
                }
            );
            modelBuilder.Entity<EmploymentType>().HasData(
               new EmploymentType()
               {
                   Id = 1,
                   Name = "Full-time",
               },
               new EmploymentType()
               {
                   Id = 2,
                   Name = "Part-time",
               },
               new EmploymentType()
               {
                   Id = 3,
                   Name = "Fixed-Term/Contract",
               },
               new EmploymentType()
               {
                   Id = 4,
                   Name = "Commission",
               }
            );
        }
    }
}
