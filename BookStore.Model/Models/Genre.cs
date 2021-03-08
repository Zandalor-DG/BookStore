namespace BookStore.Model.Models
{
    #region << Using >>

    using System.Collections.Generic;

    #endregion

    public class Genre
    {
        #region Properties

        public int Id { get; set; }

        public string Name { get; set; }

        public List<Book> Books { get; set; } = new List<Book>();

        #endregion
    }
}