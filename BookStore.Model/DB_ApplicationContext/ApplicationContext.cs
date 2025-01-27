﻿namespace BookStore.Model.DB_ApplicationContext
{
    #region << Using >>

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
    }
}