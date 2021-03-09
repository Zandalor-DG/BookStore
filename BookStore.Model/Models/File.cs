namespace BookStore.Model.Models
{
    #region << Using >>

    using System;

    #endregion

    public class File : IEntityBase
    {
        #region Properties

        public int Id { get; set; }

        public string OriginalName { get; set; }

        public string PathName { get; set; }

        public DateTime CrDt { get; private set; } = new DateTime();

        #endregion
    }
}