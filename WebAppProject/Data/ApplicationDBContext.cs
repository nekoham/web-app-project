﻿using Microsoft.EntityFrameworkCore;
using WebAppProject.Models;

namespace WebAppProject.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}