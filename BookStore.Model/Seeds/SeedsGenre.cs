namespace BookStore.Model.DB_ApplicationContext
{
    #region << Using >>

    using System.Collections.Generic;
    using BookStore.Model.Models;
    using BookStore.Model.Seeds;
    using Microsoft.EntityFrameworkCore;

    #endregion

    internal class SeedsGenre : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(
                                                 new List<Genre>
                                                 {
                                                        GenreDataSeed.FirstGenre,
                                                        GenreDataSeed.SecondGenre,
                                                        GenreDataSeed.ThirdGenre,
                                                        GenreDataSeed.FourthdGenre
                                                 });
        }
    }
}