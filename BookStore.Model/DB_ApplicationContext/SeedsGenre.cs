namespace BookStore.Model.DB_ApplicationContext
{
    #region << Using >>

    using System.Collections.Generic;
    using BookStore.Model.Models;
    using Microsoft.EntityFrameworkCore;

    #endregion

    internal class SeedsGenre : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(
                                                 new List<Genre>
                                                 {
                                                         new Genre()
                                                         {
                                                                 Id = 1,
                                                                 Name = "English hats",
                                                         },
                                                         new Genre()
                                                         {
                                                                 Id = 2,
                                                                 Name = "Nipples production",
                                                         },
                                                         new Genre()
                                                         {
                                                                 Id = 3,
                                                                 Name = "what England is silent about",
                                                         },
                                                         new Genre()
                                                         {
                                                                 Id = 4,
                                                                 Name = "tea with milk",
                                                         },
                                                 });
        }
    }
}