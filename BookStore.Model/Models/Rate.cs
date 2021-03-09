namespace BookStore.Model.Models
{
    #region << Using >>

    using System;
    using System.Collections.Generic;

    #endregion

    public class Rate : IEntityBase
    {
        #region Properties

        public int Id { get; set; }

        public double RateForBook { get; set; }

        public List<Book> Books { get; set; } = new List<Book>();

        public List<User> Users { get; set; } = new List<User>();

        public DateTime CrDt { get; private set; } = new DateTime();

        #endregion
    }
}