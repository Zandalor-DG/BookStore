using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Model.Models
{
    public class Rate
    {
        public int Id { get; set; }
        public double RateForBook { get; set; }
        public List<Book> Books { get; set; } = new List<Book>();
        public List<User> Users { get; set; } = new List<User>();
    }
}
