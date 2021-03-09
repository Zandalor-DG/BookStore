namespace BookStore.Model.DB_ApplicationContext
{
    #region << Using >>

    using System;
    using System.Collections.Generic;
    using BCrypt.Net;
    using BookStore.Model.Models;
    using Microsoft.EntityFrameworkCore;

    #endregion

    public class ApplicationContext : DbContext
    {
        #region Properties

        public DbSet<User> Users { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<File> Files { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Publish> Publishes { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Rate> Rates { get; set; }

        public DbSet<BookAuthor> BooksAuthors { get; set; }

        #endregion

        #region Constructors

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
                : base(options)
        {
            Database.EnsureCreated();
        }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                                                new List<User>
                                                {
                                                        new User
                                                        {
                                                                Id = 1,
                                                                FullName = "Test",
                                                                Password = BCrypt.HashPassword("test"),
                                                                Email = "test@test.ru",
                                                                DateOfBirthday = new DateTime()
                                                        },
                                                });
        }
    }
}