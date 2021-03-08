using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Model.ViewModels
{
   public class BookVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
        public decimal Price { get; set; }
        public int NumberOfPage { get; set; }
        public DateTime TheYearOfPublishing { get; set; }
        public List<AuthorVM> Authors { get; set; }
        public int PublishId { get; set; }
    }
}
