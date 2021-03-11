namespace BookStore.Model.Models
{
    #region << Using >>

    using System;

    #endregion

    public class Rate : IEntityBase
    {
        #region Properties

        public int Id { get; set; }

        public double RateForBook { get; set; }

        public Book Book { get; set; }

        public User User { get; set; }

        public DateTime CrDt { get; private set; } = new DateTime();

        #endregion
    }
}