namespace BookStore.Model.DB_ApplicationContext
{
    #region << Using >>

    using System.Collections.Generic;
    using BookStore.Model.Models;
    using Microsoft.EntityFrameworkCore;

    #endregion

    internal class SeedsAuthor : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(
                                                  new List<Author>
                                                  {
                                                          new Author()
                                                          {
                                                                  Id = 1,
                                                                  Name = "Anita Diamant",
                                                          },
                                                          new Author()
                                                          {
                                                                  Id = 2,
                                                                  Name = "John Irving",
                                                          },
                                                          new Author()
                                                          {
                                                                  Id = 3,
                                                                  Name = "Elizabeth Strout",
                                                          },
                                                          new Author()
                                                          {
                                                                  Id = 4,
                                                                  Name = "Kaitlyn Greenidge",
                                                          },
                                                          new Author()
                                                          {
                                                                  Id = 5,
                                                                  Name = "Edith Wharton",
                                                          },
                                                          new Author()
                                                          {
                                                                  Id = 6,
                                                                  Name = "Richard Yates",
                                                          },
                                                          new Author()
                                                          {
                                                                  Id = 7,
                                                                  Name = "Richard Russo",
                                                          },
                                                          new Author()
                                                          {
                                                                  Id = 8,
                                                                  Name = "J. Courtney Sullivan",
                                                          },
                                                          new Author()
                                                          {
                                                                  Id = 9,
                                                                  Name = "Laurie Halse Anderson",
                                                          },
                                                          new Author()
                                                          {
                                                                  Id = 10,
                                                                  Name = "Anita Shreve",
                                                          },
                                                          new Author()
                                                          {
                                                                  Id = 11,
                                                                  Name = "Joyce Maynard",
                                                          },
                                                          new Author()
                                                          {
                                                                  Id = 12,
                                                                  Name = "Zadie Smith",
                                                          },
                                                          new Author()
                                                          {
                                                                  Id = 13,
                                                                  Name = "Jennifer Haigh",
                                                          },
                                                          new Author()
                                                          {
                                                                  Id = 14,
                                                                  Name = "Becca Fitzpatrick",
                                                          },
                                                          new Author()
                                                          {
                                                                  Id = 15,
                                                                  Name = "Jhumpa Lahiri",
                                                          },
                                                          new Author()
                                                          {
                                                                  Id = 16,
                                                                  Name = "Bret Easton Ellis",
                                                          },
                                                          new Author()
                                                          {
                                                                  Id = 17,
                                                                  Name = "David Foster Wallace",
                                                          },
                                                          new Author()
                                                          {
                                                                  Id = 18,
                                                                  Name = "Jonathan Franzen",
                                                          },
                                                          new Author()
                                                          {
                                                                  Id = 19,
                                                                  Name = "Helen Oyeyemi",
                                                          },
                                                          new Author()
                                                          {
                                                                  Id = 20,
                                                                  Name = "Sylvia Plath",
                                                          },
                                                  });
        }
    }
}