namespace BookStore.Model.DB_ApplicationContext
{
    #region << Using >>

    using System.Collections.Generic;
    using BookStore.Model.Models;
    using BookStore.Model.Seeds;
    using Microsoft.EntityFrameworkCore;

    #endregion

    internal class SeedsBooksGenre : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookGenre>().HasData(
                                                     new List<BookGenre>
                                                     {
                                                             new BookGenre()
                                                             {
                                                                     Id = 1,
                                                                     Book = BooksDataSeed.FirstBook,
                                                                     Genre = GenreDataSeed.FirstGenre,
                                                             },
                                                             new BookGenre()
                                                             {
                                                                     Id = 2,
                                                                     Book = BooksDataSeed.SecondBook,
                                                                     Genre = GenreDataSeed.SecondGenre,
                                                             },
                                                             new BookGenre()
                                                             {
                                                                     Id = 3,
                                                                     Book = BooksDataSeed.ThirdBook,
                                                                     Genre = GenreDataSeed.ThirdGenre,
                                                             },
                                                             new BookGenre()
                                                             {
                                                                     Id = 4,
                                                                     Book = BooksDataSeed.FourthdBook,
                                                                     Genre = GenreDataSeed.FourthdGenre,
                                                             },
                                                             new BookGenre()
                                                             {
                                                                     Id = 5,
                                                                     Book = BooksDataSeed.FifthBook,
                                                                     Genre = GenreDataSeed.FourthdGenre,
                                                             },
                                                             new BookGenre()
                                                             {
                                                                     Id = 6,
                                                                     Book = BooksDataSeed.SixthBook,
                                                                     Genre = GenreDataSeed.FirstGenre,
                                                             },
                                                             new BookGenre()
                                                             {
                                                                     Id = 7,
                                                                     Book = BooksDataSeed.SeventhBook,
                                                                     Genre = GenreDataSeed.SecondGenre,
                                                             },
                                                             new BookGenre()
                                                             {
                                                                     Id = 8,
                                                                     Book = BooksDataSeed.EighthBook,
                                                                     Genre = GenreDataSeed.ThirdGenre,
                                                             },
                                                             new BookGenre()
                                                             {
                                                                     Id = 9,
                                                                     Book = BooksDataSeed.NinthBook,
                                                                     Genre = GenreDataSeed.FourthdGenre,
                                                             },
                                                             new BookGenre()
                                                             {
                                                                     Id = 10,
                                                                     Book = BooksDataSeed.TenthBook,
                                                                     Genre = GenreDataSeed.FirstGenre,
                                                             },
                                                     });
        }
    }
}