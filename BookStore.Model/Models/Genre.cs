namespace BookStore.Model.Models
{
    #region << Using >>

    using System;
    using System.Collections.Generic;

    #endregion

    public class Genre : IEntityBase
    {
        #region Properties

        public int Id { get; set; }

        public string Name { get; set; }

        public List<Book> Books { get; set; } = new List<Book>();

        public DateTime CrDt { get; private set; } = new DateTime();

        #endregion
    }
}