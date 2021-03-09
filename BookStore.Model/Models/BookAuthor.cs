namespace BookStore.Model.Models
{
    #region << Using >>

    using System;

    #endregion

    public class BookAuthor : IEntityBase
    {
        #region Properties

        public int Id { get; set; }

        public Book Book { get; set; }

        public Author Author { get; set; }

        public DateTime CrDt { get; private set; } = new DateTime();

        #endregion
    }
}