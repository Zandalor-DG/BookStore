namespace BookStore.Model.Seeds
{
    #region << Using >>

    using BookStore.Model.Models;

    #endregion

    public abstract class GenreDataSeed
    {
        #region Constants

        public static Genre FirstGenre = new Genre()
                                         {
                                                 Id = 1,
                                                 Name = "Melodrama",
                                         };

        public static Genre SecondGenre = new Genre()
                                          {
                                                  Id = 2,
                                                  Name = "Romance",
                                          };

        public static Genre ThirdGenre = new Genre()
                                         {
                                                 Id = 3,
                                                 Name = "Drama",
                                         };

        public static Genre FourthdGenre = new Genre()
                                           {
                                                   Id = 4,
                                                   Name = "Psychological realism",
                                           };

        #endregion
    }
}