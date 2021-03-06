﻿using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.IEntityFramework
{
    public class ReCapProjectContext :DbContext
    {
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=ReCapProjectDb; Trusted_Connection=true");
        }

        //Tablodaki veriler ile Programdaki verileri eşleştirdiğimiz alan ! 
        public DbSet<Car> Cars { get; set; } 
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Colors> Colors { get; set; }
        public DbSet<Entities.Concrete.User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<CarImage> CarImages { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<Core.Entities.Concrete.User> Userss { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

    }
}
