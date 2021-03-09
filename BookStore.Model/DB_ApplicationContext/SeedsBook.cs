namespace BookStore.Model.DB_ApplicationContext
{
    #region << Using >>

    using System;
    using System.Collections.Generic;
    using BookStore.Model.Models;
    using Microsoft.EntityFrameworkCore;

    #endregion

    internal class SeedsBook : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                                                new List<Book>()
                                                {
                                                        new Book()
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
                                                        },
                                                        new Book()
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
                                                        },
                                                        new Book()
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
                                                        },
                                                        new Book()
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
                                                        },
                                                        new Book()
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
                                                        },
                                                        new Book()
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
                                                        },
                                                        new Book()
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
                                                        },
                                                        new Book()
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
                                                        },
                                                        new Book()
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
                                                        },
                                                        new Book()
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
                                                        },
                                                        new Book()
                                                        {
                                                                Id = 11,
                                                                Name = "Labor Day",
                                                                Price = 419,
                                                                PublishId = 3,
                                                                CoverId = 11,
                                                                TheYearOfPublishing = new DateTime(2017, 6, 16),
                                                                Language = "English",
                                                                NumberOfPage = 478,
                                                                Description = "'All red' - so aptly Joanna translated from Danish the name of the town of"
                                                                            + " Allerod in Denmark and,  as they say, 'nakarkala'.The name turned out to"
                                                                            + " be visionary.At a fun party of Polish friends, a mysterious murder takes"
                                                                            + " place.The unfortunate man tries to warn the mistress of the house, Alicia,"
                                                                            + " about something very important, but does not have time ...Alicia becomes"
                                                                            + " a target for a series of subsequent 'unsuccessful' attempts.Joining their"
                                                                            + " efforts, John and Alicia find the murderer through logic, passion and"
                                                                            + " excellent knowledge of human nature.Of course, this book is not for fans"
                                                                            + " of 'cool' detective stories, although the number of 'living' corpses is"
                                                                            + " impressive.The novel primarily attracts the reader with its sparkling humor"
                                                                            + " and irony. Ioanna Khmelevskaya is able to see the irony and grotesque in the"
                                                                            + " most unusual situations.The novel 'Everything Red' is rightfully recognized"
                                                                            + " as one of the brightest and most dynamic works of the Polish writer.",
                                                        },
                                                        new Book()
                                                        {
                                                                Id = 12,
                                                                Name = "On Beauty",
                                                                Price = 311,
                                                                PublishId = 3,
                                                                CoverId = 12,
                                                                TheYearOfPublishing = new DateTime(2011, 5, 21),
                                                                Language = "English",
                                                                NumberOfPage = 378,
                                                                Description = "The king is dead, long live the king! .. However, what kind of king is alive?"
                                                                            + " The one that turned into a ghost? Or his killer, an impostor who seemed to"
                                                                            + " be slightly moved by his mind? And then the earth came to life ...And the"
                                                                            + " witches ...And the prince-heir, moonlighting as an actor ...No, that's it,"
                                                                            + " we wash our hands.Read it yourself.",
                                                        },
                                                        new Book()
                                                        {
                                                                Id = 13,
                                                                Name = "Faith",
                                                                Price = 212,
                                                                PublishId = 3,
                                                                CoverId = 13,
                                                                TheYearOfPublishing = new DateTime(2016, 8, 19),
                                                                Language = "English",
                                                                NumberOfPage = 418,
                                                                Description = "'The Adventures of Emil of Lenneberg' is one of the most popular and"
                                                                            + " beloved books by Astrid Lindgren by children all over the world.It is"
                                                                            + " about a whirlwind little boy with blue eyes, who only does what is"
                                                                            + " mischievous.Well, who would think of pouring dough on his dad's head,"
                                                                            + " set fire to the feather on the pastor's hat, and feed the rooster and"
                                                                            + " the pig with drunk cherries?",
                                                        },
                                                        new Book()
                                                        {
                                                                Id = 14,
                                                                Name = "Hush, Hush",
                                                                Price = 311,
                                                                PublishId = 3,
                                                                CoverId = 14,
                                                                TheYearOfPublishing = new DateTime(2016, 1, 1),
                                                                Language = "English",
                                                                NumberOfPage = 557,
                                                                Description = "Before you is the long-awaited sequel to the world's best book about"
                                                                            + " childhood - the novel by Narine Abgaryan 'Manyunya'. To everyone who"
                                                                            + " has already managed to get to know and fall in love with the funny"
                                                                            + " girlfriends-hooligans Nara and Manyunya, the harsh but charming Ba -"
                                                                            + " Manyuni's grandmother and a crowd of their noisy and awkward relatives,"
                                                                            + " as well as those who have just got to know this terribly pleasant"
                                                                            + " acquaintance, we present a book about new adventures Manyuni! If you"
                                                                            + " think that you know what two girls of primary school age are capable of"
                                                                            + ", who do not sit still and want to spend their childhood so that not a"
                                                                            + " single minute of it is boring, then you still do not know anything"
                                                                            + " ...Read and be horrified, that is, enjoy, of course!",
                                                        },
                                                        new Book()
                                                        {
                                                                Id = 15,
                                                                Name = "Interpreter of Maladies",
                                                                Price = 212,
                                                                PublishId = 3,
                                                                CoverId = 15,
                                                                TheYearOfPublishing = new DateTime(2011, 1, 1),
                                                                Language = "English",
                                                                NumberOfPage = 708,
                                                                Description = "A charming quiet town on the Mississippi, a sun-drenched green valley,"
                                                                            + " simple - minded and touching people, an atmosphere of play and romance"
                                                                            + " ...These are The Adventures of Tom Sawyer by Mark Twain, a harmonious"
                                                                            + " and joyful book.This exciting story about the ringleader, the boy's"
                                                                            + " chieftain Tom Sawyer and his friend, the street child Huckleberry Finn,"
                                                                            + " almost immediately became a classic of children's literature.At the same"
                                                                            + " time, Mark Twain assured that his book ' is not at all for children, oh "
                                                                            + "no.It will interest only an adult.It was written for adults.' Not obeying"
                                                                            + " the notions of how well-bred boys should behave, funny and daring (and at"
                                                                            + " the same time different, and each - a personality!) Tomboys Tom and Huck"
                                                                            + " became the embodiment of the 'American dream'.With courage, enthusiasm and"
                                                                            + " faith in themselves, they seek their right to freedom and happiness - at"
                                                                            + " school and in church; on the wooded island of Jackson as pirates; at a"
                                                                            + " court hearing when it is necessary to save an innocent person; in a"
                                                                            + " terrible abandoned house where treasure is hidden, and in the labyrinths"
                                                                            + " of MacDougal's cave ...",
                                                        },
                                                        new Book()
                                                        {
                                                                Id = 16,
                                                                Name = "The Rules of Attraction",
                                                                Price = 199,
                                                                PublishId = 4,
                                                                CoverId = 16,
                                                                TheYearOfPublishing = new DateTime(2013, 10, 21),
                                                                Language = "English",
                                                                NumberOfPage = 621,
                                                                Description = "The collection presents the famous plays of Oscar Wilde= the drama"
                                                                            + " 'Salome' and the evil, endlessly witty, exquisitely frivolous comedies"
                                                                            + " 'Lady Windermere's Fan', 'The Ideal Husband', 'The Importance of Being"
                                                                            + " Earnest'.",
                                                        },
                                                        new Book()
                                                        {
                                                                Id = 17,
                                                                Name = "Infinite Jest",
                                                                Price = 299,
                                                                PublishId = 4,
                                                                CoverId = 17,
                                                                TheYearOfPublishing = new DateTime(2014, 11, 14),
                                                                Language = "English",
                                                                NumberOfPage = 410,
                                                                Description = "The news of the death of his father finds Jad Foxman in a difficult moment="
                                                                            + " he has lost his job and is experiencing his wife's betrayal. Now he has"
                                                                            + " to spend a mourning week with his closest relatives, and communication"
                                                                            + " with them is always a test. The fact that the Foxmans have gathered on a"
                                                                            + " sad occasion does not prevent them from practicing wit, getting into"
                                                                            + " ridiculous situations and sorting things out. For seven days of mourning,"
                                                                            + " the hero's ideas about life and himself will radically change, and those"
                                                                            + " close to him will present him and each other with many surprises.",
                                                        },
                                                        new Book()
                                                        {
                                                                Id = 18,
                                                                Name = "Strong Motion",
                                                                Price = 399,
                                                                PublishId = 4,
                                                                CoverId = 18,
                                                                TheYearOfPublishing = new DateTime(2018, 2, 11),
                                                                Language = "English",
                                                                NumberOfPage = 278,
                                                                Description = "Book of Mikhail Weller 'Legends of Nevsky Prospect'.That rare book over"
                                                                            + " which you laugh out loud! When I read it for the first time (and this"
                                                                            + " was before e-books) I bought several copies and gave them to my friends!",
                                                        },
                                                        new Book()
                                                        {
                                                                Id = 19,
                                                                Name = "Boy, Snow, Bird",
                                                                Price = 400,
                                                                PublishId = 4,
                                                                CoverId = 19,
                                                                TheYearOfPublishing = new DateTime(1989, 3, 24),
                                                                Language = "English",
                                                                NumberOfPage = 278,
                                                                Description = "With this book, I just sobbed with laughter.Sooooo positive thing.There"
                                                                            + " are a couple of chapters in it, over which a lump rolls up to the throat,"
                                                                            + " but overall the impression is joyful from the book.",
                                                        },
                                                        new Book()
                                                        {
                                                                Id = 20,
                                                                Name = "The Bell Jar",
                                                                Price = 229,
                                                                PublishId = 4,
                                                                CoverId = 20,
                                                                TheYearOfPublishing = new DateTime(1991, 1, 12),
                                                                Language = "English",
                                                                NumberOfPage = 278,
                                                                Description = "An amazing fusion of an adventurous novel, an unbridled comic position,"
                                                                            + " folklore, philosophical insights, fairy tales and were, sounding"
                                                                            + " especially modern in the post-totalitarian period of our history,"
                                                                            + "  is the main book of Leonid Solovyov (1906-1962). Hodja Nasreddin is"
                                                                            + " the brother of such immortal images of world literature as Sancho Panza"
                                                                            + " Cervantes, Til Ulenspiegel Charles de Coster, Cola Brunoi Romain Rolland,"
                                                                            + " the soldier Svejk Hasek, the grandfather of Shchukar Mikhail Sholokhov.",
                                                        },
                                                }
                                               );
        }
    }
}