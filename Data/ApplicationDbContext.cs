using System;
using System.Collections.Generic;
using System.Text;
using EntityReview.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EntityReview.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Cat> Cat {get; set;}
        public DbSet<Dog> Dog {get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            ApplicationUser user = new ApplicationUser
            {
                Boom = "KHBOOM",
                FirstName = "admin",
                LastName = "admin",
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
            Cat maisey = new Cat()
            {
                Id = 1,
                Name = "Maisey",
                Breed = "cranky",
                Gender = "female",
                IsChonky = true,
                IsFixed = true

            };
            modelBuilder.Entity<Cat>().HasData(maisey);


            Cat Todd = new Cat()
            {
                Id = 2,
                Name = "Todd",
                Breed = "cranky",
                Gender = "male",
                IsChonky = false,
                IsFixed = true

            };
            modelBuilder.Entity<Cat>().HasData(Todd);



            Dog bonnie = new Dog()
            {
                Id = 1,
                Name = "Bonnie",
                Breed = "pit/mix",
                Gender = "female",
                IsChonky = false,
                IsFixed = true
            };
            modelBuilder.Entity<Dog>().HasData(bonnie);

            //if theres user related data this needs to go before the objects but we dont have users so we can put it after 

        }
    }
    }
