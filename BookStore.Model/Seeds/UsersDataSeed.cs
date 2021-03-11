namespace BookStore.Model.Seeds
{
    #region << Using >>

    using System;
    using BCrypt.Net;
    using BookStore.Model.Models;

    #endregion

    public static class UsersDataSeed
    {
        #region Constants

        public static User FirstUser = new User()
                                       {
                                               Id = 1,
                                               FullName = "Test",
                                               Password = BCrypt.HashPassword("test"),
                                               Email = "test@test.ru",
                                               DateOfBirthday = new DateTime()
                                       };

        public static User SecondUser = new User()
                                        {
                                                Id = 2,
                                                FullName = "TestSecond",
                                                Password = BCrypt.HashPassword("testSecond"),
                                                Email = "testSecond@test.ru",
                                                DateOfBirthday = new DateTime()
                                        };

        public static User ThirdUser = new User()
                                       {
                                               Id = 3,
                                               FullName = "TestThird",
                                               Password = BCrypt.HashPassword("testThird"),
                                               Email = "testThird@test.ru",
                                               DateOfBirthday = new DateTime()
                                       };

        #endregion
    }
}