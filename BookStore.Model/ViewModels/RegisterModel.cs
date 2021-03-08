using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Model.ViewModels
{
    using System.ComponentModel.DataAnnotations;

    public class RegisterModel
    {

        [Required(ErrorMessage = "Не указан Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Пароль введен неверно")]
        public string ConfirmPassword { get; set; }

    }
}
