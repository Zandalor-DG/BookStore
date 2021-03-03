using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;

namespace BookStore.DB.Models
{
    public class User
    {
        public virtual int Id { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string Email { get; set; }

        public class UserMap : ClassMap<User>
        {
            public UserMap()
            {
                Id(x => x.Id);
                Map(x => x.FirstName);
                Map(x => x.Email);
            } 
        }
    }
}
