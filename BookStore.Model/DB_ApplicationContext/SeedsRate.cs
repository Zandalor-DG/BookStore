namespace BookStore.Model.DB_ApplicationContext
{
    #region << Using >>

    using System.Collections.Generic;
    using BookStore.Model.Models;
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
                                                        },
                                                });
        }
    }
}