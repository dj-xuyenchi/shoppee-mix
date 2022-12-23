﻿using Microsoft.EntityFrameworkCore;
using RINGAWEB.Entities;

namespace RINGAWEB.Context
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Property> Properties { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Config.dbConectionName());
        }
    }
}