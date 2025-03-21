﻿using Microsoft.EntityFrameworkCore;

namespace E_Commerce_DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Category> categories { get; set; }
    }
}
