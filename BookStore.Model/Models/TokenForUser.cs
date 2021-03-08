using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Model.Models
{
    using Microsoft.IdentityModel.Tokens;

    public class TokenForUser
    {
        public static string ISSUER = "Zandalor";

        public static string AUDIENCE = "UserMyBookStore";

        private const string KEY = "Zandalor";

        public const int LIFETIME = 2880;

        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
        }
    }
}
