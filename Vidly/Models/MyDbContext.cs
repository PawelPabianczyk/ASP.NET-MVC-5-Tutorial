﻿using System.Data.Entity;

namespace Vidly.Models
{
    public class MyDbContext:DbContext
    {
        //public MyDBContext()
        //{
        //    return;
        //}
        public DbSet<Customer> Customers { get; set; } // My domain models
        public DbSet<Movie> Movies { get; set; }// My domain models
        public DbSet<MembershipType> MembershipTypes { get; set; }// My domain models
    }
}