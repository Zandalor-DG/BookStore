namespace BookStore.Model.Seeds
{
    #region << Using >>

    using System.Collections.Generic;
    using BookStore.Model.Models;
    using Microsoft.EntityFrameworkCore;

    #endregion

    internal class SeedsPublish : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Publish>().HasData(
                                                   new List<Publish>
                                                   {
                                                           new Publish()
                                                           {
                                                                   Id = 1,
                                                                   Name = "English hats",
                                                           },

                                                           new Publish()
                                                           {
                                                                   Id = 2,
                                                                   Name = "Nipples production",
                                                           },
                                                           new Publish()
                                                           {
                                                                   Id = 3,
                                                                   Name = "what England is silent about",
                                                           },
                                                           new Publish()
                                                           {
                                                                   Id = 4,
                                                                   Name = "tea with milk",
                                                           },
                                                   });
        }
    }
}