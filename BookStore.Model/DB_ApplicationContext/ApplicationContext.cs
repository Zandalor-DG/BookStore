using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Model.DB_ApplicationContext
{
    using BookStore.Model.Models;
    using Microsoft.EntityFrameworkCore;

    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
                : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
