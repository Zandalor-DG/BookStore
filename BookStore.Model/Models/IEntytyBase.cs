namespace BookStore.Model.Models
{
    #region << Using >>

    using System;

    #endregion

    public interface IEntityBase
    {
        #region Properties

        int Id { get; set; }

        DateTime CrDt { get; }

        #endregion
    }
}