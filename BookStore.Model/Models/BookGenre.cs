namespace BookStore.Model.Models
{
    #region << Using >>

    using System;

    #endregion

    public class BookGenre : IEntityBase

    {
        #region Properties

        public int Id { get; set; }

        public Book Book { get; set; }

        public Genre Genre { get; set; }

        public DateTime CrDt { get; set; }= DateTime.UtcNow;

        #endregion
    }
}