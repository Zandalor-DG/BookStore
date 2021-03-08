using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Model.Models
{
    public class BookAuthor
    {
        public Book Book { get; set; }
        public Author Author { get; set; }
    }
}
