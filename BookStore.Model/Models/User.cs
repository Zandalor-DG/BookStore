﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Model.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime DateOfBirthday { get; set; }
        public int AvatarId { get; set; }
    }
}
