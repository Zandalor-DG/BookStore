namespace BookStore.Model.DB_ApplicationContext
{
    #region << Using >>

    using System.Collections.Generic;
    using BookStore.Model.Models;
    using BookStore.Model.Seeds;
    using Microsoft.EntityFrameworkCore;

    #endregion

    class SeedsRate : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rate>().HasData(
                                                new List<Rate>
                                                {
                                                        new Rate()
                                                        {
                                                                Id = 1,
                                                                RateForBook = 1,
                                                                Book = BooksDataSeed.FirstBook,
                                                                User = UsersDataSeed.FirstUser,
                                                        },
                                                        new Rate()
                                                        {
                                                                Id = 2,
                                                                RateForBook = 3,
                                                                Book = BooksDataSeed.FirstBook,
                                                                User = UsersDataSeed.SecondUser,
                                                        },
                                                        new Rate()
                                                        {
                                                                Id = 3,
                                                                RateForBook = 5,
                                                                Book = BooksDataSeed.FirstBook,
                                                                User = UsersDataSeed.ThirdUser,
                                                        },
                                                });
        }
    }
}