using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Model.ViewModels
{
    public class AuthorVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<BookVM> Books { get; set; }
    }
}
