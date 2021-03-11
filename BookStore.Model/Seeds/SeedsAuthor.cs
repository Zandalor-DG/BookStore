namespace BookStore.Model.DB_ApplicationContext
{
    #region << Using >>

    using System.Collections.Generic;
    using BookStore.Model.Models;
    using BookStore.Model.Seeds;
    using Microsoft.EntityFrameworkCore;

    #endregion

    internal class SeedsAuthor : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(
                                                  new List<Author>
                                                  {
                                                         AuthorDataSeed.FirstAuthor,
                                                         AuthorDataSeed.SecondAuthor,
                                                         AuthorDataSeed.ThirdAuthor,
                                                         AuthorDataSeed.FourthdAuthor,
                                                         AuthorDataSeed.FifthAuthor,
                                                         AuthorDataSeed.SixthAuthor,
                                                         AuthorDataSeed.SeventhAuthor,
                                                         AuthorDataSeed.EighthAuthor,
                                                         AuthorDataSeed.NinthAuthor,
                                                         AuthorDataSeed.TenthAuthor
                                                  });
        }
    }
}