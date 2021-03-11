namespace BookStore.Model.Seeds
{
    #region << Using >>

    using System.Collections.Generic;
    using BookStore.Model.Models;
    using Microsoft.EntityFrameworkCore;

    #endregion

    public class SeedsBookAuthor : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookAuthor>().HasData(
                                                      new List<BookAuthor>
                                                      {
                                                              new BookAuthor()
                                                              {
                                                                      Id = 1,
                                                                      Book = BooksDataSeed.FirstBook,
                                                                      Author = AuthorDataSeed.FirstAuthor,
                                                              },
                                                              new BookAuthor()
                                                              {
                                                                      Id = 2,
                                                                      Book = BooksDataSeed.SecondBook,
                                                                      Author = AuthorDataSeed.SecondAuthor,
                                                              },
                                                              new BookAuthor()
                                                              {
                                                                      Id = 3,
                                                                      Book = BooksDataSeed.ThirdBook,
                                                                      Author = AuthorDataSeed.ThirdAuthor,
                                                              },
                                                              new BookAuthor()
                                                              {
                                                                      Id = 4,
                                                                      Book = BooksDataSeed.FourthdBook,
                                                                      Author = AuthorDataSeed.FourthdAuthor,
                                                              },
                                                              new BookAuthor()
                                                              {
                                                                      Id = 5,
                                                                      Book = BooksDataSeed.FifthBook,
                                                                      Author = AuthorDataSeed.FifthAuthor,
                                                              },
                                                              new BookAuthor()
                                                              {
                                                                      Id = 6,
                                                                      Book = BooksDataSeed.SixthBook,
                                                                      Author = AuthorDataSeed.SixthAuthor,
                                                              },
                                                              new BookAuthor()
                                                              {
                                                                      Id = 7,
                                                                      Book = BooksDataSeed.SeventhBook,
                                                                      Author = AuthorDataSeed.SeventhAuthor,
                                                              },
                                                              new BookAuthor()
                                                              {
                                                                      Id = 8,
                                                                      Book = BooksDataSeed.EighthBook,
                                                                      Author = AuthorDataSeed.EighthAuthor,
                                                              },
                                                              new BookAuthor()
                                                              {
                                                                      Id = 9,
                                                                      Book = BooksDataSeed.NinthBook,
                                                                      Author = AuthorDataSeed.NinthAuthor,
                                                              },
                                                              new BookAuthor()
                                                              {
                                                                      Id = 10,
                                                                      Book = BooksDataSeed.TenthBook,
                                                                      Author = AuthorDataSeed.TenthAuthor,
                                                              },
                                                      });
        }
    }
}