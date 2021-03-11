using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Model.Seeds
{
    using BookStore.Model.Models;
    using Microsoft.EntityFrameworkCore;
    using BCrypt.Net;

    public class SeedsUser : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                                                new List<User>
                                                {
                                                        UsersDataSeed.FirstUser,
                                                        UsersDataSeed.SecondUser,
                                                        UsersDataSeed.ThirdUser
                                                });
        }
    }
}
