namespace BookStore.Model.Models
{
    #region << Using >>

    using System;

    #endregion

    public class Book : IEntityBase
    {
        #region Properties

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Language { get; set; }

        public decimal Price { get; set; }

        public int NumberOfPage { get; set; }

        public DateTime TheYearOfPublishing { get; set; }

        public int PublishId { get; set; }

        public int CoverId { get; set; }

        public DateTime CrDt { get; private set; } = DateTime.UtcNow;

        #endregion
    }
}