namespace BookStore.Model.Models
{
    #region << Using >>

    using System;

    #endregion

    public class User : IEntityBase
    {
        #region Properties

        public int Id { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public DateTime DateOfBirthday { get; set; }

        public int AvatarId { get; set; }

        public DateTime CrDt { get; private set; } = new DateTime();

        #endregion
    }
}