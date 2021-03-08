using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Model.ViewModels
{
    public class RateVM
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }
        public double RateForBook { get; set; }
    }
}
