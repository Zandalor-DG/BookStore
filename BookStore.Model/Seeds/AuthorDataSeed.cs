namespace BookStore.Model.Seeds
{
    #region << Using >>

    using BookStore.Model.Models;

    #endregion

    public abstract class AuthorDataSeed
    {
        #region Constants

        public static Author FirstAuthor = new Author()
                                           {
                                                   Id = 1,
                                                   Name = "Anita Diamant",
                                           };

        public static Author SecondAuthor = new Author()
                                            {
                                                    Id = 2,
                                                    Name = "John Irving",
                                            };

        public static Author ThirdAuthor = new Author()
                                           {
                                                   Id = 3,
                                                   Name = "Elizabeth Strout",
                                           };

        public static Author FourthdAuthor = new Author()
                                             {
                                                     Id = 4,
                                                     Name = "Kaitlyn Greenidge",
                                             };

        public static Author FifthAuthor = new Author()
                                           {
                                                   Id = 5,
                                                   Name = "Edith Wharton",
                                           };

        public static Author SixthAuthor = new Author()
                                           {
                                                   Id = 6,
                                                   Name = "Richard Yates",
                                           };

        public static Author SeventhAuthor = new Author()
                                             {
                                                     Id = 7,
                                                     Name = "Richard Russo",
                                             };

        public static Author EighthAuthor = new Author()
                                            {
                                                    Id = 8,
                                                    Name = "J. Courtney Sullivan",
                                            };

        public static Author NinthAuthor = new Author()
                                           {
                                                   Id = 9,
                                                   Name = "Laurie Halse Anderson",
                                           };

        public static Author TenthAuthor = new Author()
                                           {
                                                   Id = 10,
                                                   Name = "Anita Shreve",
                                           };

        #endregion
    }
}