namespace BookStore.Model.Seeds
{
    #region << Using >>

    using System;
    using BookStore.Model.Models;

    #endregion

    public abstract class BooksDataSeed
    {
        #region Constants

        public static Book FirstBook = new Book()
                                       {
                                               Id = 1,
                                               Name = "The Boston Girl",
                                               Price = 100,
                                               PublishId = 1,
                                               CoverId = 1,
                                               TheYearOfPublishing = new DateTime(2016, 1, 1),
                                               Language = "English",
                                               NumberOfPage = 278,
                                               Description = "About Fedot the archer, a dashing fellow"
                                                           + "is a superbly stylized poetic fairy tale-allegory "
                                                           + " written by Leonid Filatov. The world, in which there "
                                                           + "are typical characters of Russian fairy tales and fantastic "
                                                           + "creatures, is sure to be a miracle that will help make the "
                                                           + "impossible possible, and the main character will finally find "
                                                           + "the To-Chavo-Not-Can-Be. All these are invariable signs of the "
                                                           + "genre, without which a fairy tale ceases to be a fairy tale."
                                                           + " Bright, colorful, funny, caustic verses of Filatov the "
                                                           + "storyteller will captivate, surprise and amuse the reader ...",
                                       };

        public static Book SecondBook = new Book()
                                        {
                                                Id = 2,
                                                Name = "The Cider House Rules",
                                                Price = 121,
                                                PublishId = 1,
                                                CoverId = 2,
                                                TheYearOfPublishing = new DateTime(2012, 10, 11),
                                                Language = "English",
                                                NumberOfPage = 378,
                                                Description = "In Russian literature of the 20th century, Ilya Ilf "
                                                            + "and Yevgeny Petrov occupy the place of the most beloved "
                                                            + "writers of the humorous, satirical direction among the people."
                                                            + " The famous novel 'The Twelve Chairs' was first published in 1927"
                                                            + " and has since become one of the most popular and read books. "
                                                            + "This reprint includes illustrations by artist Mark Lisogorsky,"
                                                            + " which have not been published anywhere before. The uniqueness "
                                                            + "of this book lies in the fact that it is part of a trilogy, which,"
                                                            + " in addition to the novels 'Twelve Chairs' and 'The Golden Calf' "
                                                            + "by Ilya Ilf and Yevgeny Petrov, includes a 'long-awaited' sequel "
                                                            + "- the novel 'The Triumph of the Great Combinator', written by a modern"
                                                            + " writer Boris Leontiev.",
                                        };

        public static Book ThirdBook = new Book()
                                       {
                                               Id = 3,
                                               Name = "Olive Kitteridge",
                                               Price = 130,
                                               PublishId = 1,
                                               CoverId = 3,
                                               TheYearOfPublishing = new DateTime(2010, 11, 1),
                                               Language = "English",
                                               NumberOfPage = 272,
                                               Description = "Jerome Klapka Jerome (1859-1927) is a famous English writer,"
                                                           + " whose works are marked by good-natured humor. The book includes"
                                                           + " two stories= the widely known 'Three in a boat, not counting"
                                                           + " a dog' (1889) and 'Three on bicycles' (1900), published in"
                                                           + " a new translation. Contains illustrations.",
                                       };

        public static Book FourthdBook = new Book()
                                         {
                                                 Id = 4,
                                                 Name = "We Love You, Charlie Freeman",
                                                 Price = 141,
                                                 PublishId = 1,
                                                 CoverId = 4,
                                                 TheYearOfPublishing = new DateTime(2016, 1, 1),
                                                 Language = "English",
                                                 NumberOfPage = 678,
                                                 Description = "Oh, and it's hard for you, witch's share! Fate will bring it into"
                                                             + " the vampire valley, then into the dragon's cave, then the ghouls"
                                                             + " play pranks in the cemetery, then there is no way to save honest"
                                                             + " people from werewolves. In addition, competitors are striving to"
                                                             + " steal a profitable job from under their noses, priests anathematize,"
                                                             + " villagers fearfully look askance, and the king fights taxes ..."
                                                             + " But if you are young, talented and your magic reserve is more"
                                                             + " likely half full than half empty, that's all. this is bullshit!"
                                                             + " The main thing is adventure and true love!",
                                         };

        public static Book FifthBook = new Book()
                                       {
                                               Id = 5,
                                               Name = "Ethan Frome",
                                               Price = 200,
                                               PublishId = 1,
                                               CoverId = 5,
                                               TheYearOfPublishing = new DateTime(2019, 6, 11),
                                               Language = "English",
                                               NumberOfPage = 438,
                                               Description = "The collection includes the most famous stories about"
                                                           + " Denisk Korablev from the cycle 'Deniskin's stories'",
                                       };

        public static Book SixthBook = new Book()
                                       {
                                               Id = 6,
                                               Name = "Revolutionary Road",
                                               Price = 199,
                                               PublishId = 2,
                                               CoverId = 6,
                                               TheYearOfPublishing = new DateTime(2014, 2, 4),
                                               Language = "English",
                                               NumberOfPage = 214,
                                               Description = "The most famous Woodhouse series about the cold-hearted Mr. Wooster"
                                                           + " and the cunning Jeeves. Stories that have been considered classics"
                                                           + " of English humorous prose for many decades. Mr. Bingo, a friend of"
                                                           + " Bertie Wooster, is once again planning to marry. But the strict uncle"
                                                           + " Little can interfere with the implementation of the wedding plans, and"
                                                           + " then the faithful Bertie, who takes on the role of mediator in this delicate"
                                                           + " matter, and his genius servant Jeeves come to the rescue. However, Mr. Wooster"
                                                           + " needs help himself - Aunt Agatha is determined to find a worthy life partner"
                                                           + " for her beloved nephew ...",
                                       };

        public static Book SeventhBook = new Book()
                                         {
                                                 Id = 7,
                                                 Name = "Empire Falls",
                                                 Price = 299,
                                                 PublishId = 2,
                                                 CoverId = 7,
                                                 TheYearOfPublishing = new DateTime(2018, 9, 23),
                                                 Language = "English",
                                                 NumberOfPage = 318,
                                                 Description = "He himself is a nondescript strong man, whose male loneliness smells like"
                                                             + " a hamster (living under the bathroom), and is carried away by almost"
                                                             + " unapproachable sad women (easy to kiss). The only plumber in the Baltics"
                                                             + " who plays in the academic theater. Blogs in 'LJ', knows how to fry meat"
                                                             + " and grow onions on the window. Who is Slava Se himself? Or his hero?"
                                                             + " And Glory Se is he?",
                                         };

        public static Book EighthBook = new Book()
                                        {
                                                Id = 8,
                                                Name = "Main",
                                                Price = 229,
                                                PublishId = 2,
                                                CoverId = 8,
                                                TheYearOfPublishing = new DateTime(2019, 10, 11),
                                                Language = "English",
                                                NumberOfPage = 421,
                                                Description = "The present reissue of the novel 'The Golden Calf' includes illustrations"
                                                            + " by the artist Mark Lisogorsky, which have not been published anywhere"
                                                            + " before. The uniqueness of this book lies in the fact that it is part of"
                                                            + " a trilogy, which, in addition to the novels 'Twelve Chairs' and 'The Golden"
                                                            + " Calf' by Ilya Ilf and Yevgeny Petrov, includes a 'long-awaited' sequel"
                                                            + " - the novel 'The Triumph of the Great Combinator', written by a modern"
                                                            + " writer Boris Leontiev.",
                                        };

        public static Book NinthBook = new Book()
                                       {
                                               Id = 9,
                                               Name = "Wintergirls",
                                               Price = 391,
                                               PublishId = 2,
                                               CoverId = 9,
                                               TheYearOfPublishing = new DateTime(2012, 11, 12),
                                               Language = "English",
                                               NumberOfPage = 478,
                                               Description = "'Manyunya' is a light, sun - drenched and scent of a southern bazaar"
                                                           + " and an amazingly funny story about childhood, about two girlfriends"
                                                           + " Nara and Manyunya, about the formidable and kind Granny Manyunya, and"
                                                           + " about a bunch of their relatives who constantly find themselves in odd"
                                                           + " situations.This is the warmest, mischievous and full of funny adventures"
                                                           + " childhood that makes a person happy for life.",
                                       };

        public static Book TenthBook = new Book()
                                       {
                                               Id = 10,
                                               Name = "The Pilot's Wife",
                                               Price = 329,
                                               PublishId = 2,
                                               CoverId = 10,
                                               TheYearOfPublishing = new DateTime(2016, 1, 1),
                                               Language = "English",
                                               NumberOfPage = 578,
                                               Description = "The Hitchhiker's Guide to the Galaxy. The legendary ironic sci-fi saga"
                                                           + " of Douglas Adams, about which so much has already been written and said"
                                                           + " that adding something else will seem stupid and almost sacrilege! However"
                                                           + " ... Do you want to know how to make the Pangalactic Gryzloder cocktail?"
                                                           + " Do you want to understand how to survive on a measly thirty Altair dollars"
                                                           + " a day? Want to playfully ruin an interplanetary super-corporation? Oh no?"
                                                           + " So, maybe you're wondering WHAT God bequeathed to the world He created ?!"
                                                           + " Read MASTERPIECE by Douglas Adams - and you will learn not only THIS, but"
                                                           + " SOMETHING ELSE!",
                                       };

        #endregion
    }
}