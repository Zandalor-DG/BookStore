using System;

namespace BookStore.Model.DB_ApplicationContext
{
    using System.Collections.Generic;
    using BookStore.Model.Models;
    using Microsoft.EntityFrameworkCore;
    using BCrypt.Net;

    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Publish> Publishes { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Rate> Rates { get; set; }
        public DbSet<BookAuthor> BooksAuthors { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
                : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                                                new List<User>
                                                {
                                                        new User {
                                                                         Id=1, 
                                                                         FullName= "Test",
                                                                         Password =  BCrypt.HashPassword("test"), 
                                                                         Email = "test@test.ru", 
                                                                         DateOfBirthday = new DateTime()

                                                                 },
                                                });
        }
    }
}
