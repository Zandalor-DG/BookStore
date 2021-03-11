namespace BookStore.Model.DB_ApplicationContext
{
    #region << Using >>

    using System.Collections.Generic;
    using BookStore.Model.Models;
    using BookStore.Model.Seeds;
    using Microsoft.EntityFrameworkCore;

    #endregion

    public class SeedsBook : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                                                new List<Book>()
                                                {
                                                        BooksDataSeed.FirstBook,
                                                        BooksDataSeed.SecondBook,
                                                        BooksDataSeed.ThirdBook,
                                                        BooksDataSeed.FourthdBook,
                                                        BooksDataSeed.FifthBook,
                                                        BooksDataSeed.SixthBook,
                                                        BooksDataSeed.SeventhBook,
                                                        BooksDataSeed.EighthBook,
                                                        BooksDataSeed.NinthBook,
                                                        BooksDataSeed.TenthBook,
                                                }
                                               );
        }
    }
}