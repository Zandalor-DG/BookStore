namespace BookStore.Model.Models
{
    #region << Using >>

    using System;

    #endregion

    public class Publish : IEntityBase
    {
        #region Properties

        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime CrDt { get; private set; } = new DateTime();

        #endregion
    }
}