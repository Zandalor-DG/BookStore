namespace BookStore.Core.Controllers
{
    #region << Using >>

    using System;
    using System.Collections.Generic;
    using System.IdentityModel.Tokens.Jwt;
    using System.Security.Claims;
    using System.Threading.Tasks;
    using BCrypt.Net;
    using BookStore.Model.DB_ApplicationContext;
    using BookStore.Model.Models;
    using BookStore.Model.ViewModels;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.IdentityModel.Tokens;

    #endregion

    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        #region Properties

        private readonly ApplicationContext db;

        #endregion

        #region Constructors

        public AccountController(ApplicationContext context)
        {
            this.db = context;
        }

        #endregion

        // Post: api/Account
        [HttpPost]
        public async Task<ActionResult<User>> SignUp(RegisterModel registerUser)
        {
            var candidate = await this.db.Users.FirstAsync(u => u.Email == registerUser.Email);
            if (candidate != null)
                return BadRequest("User already exists");

            var passwordHash = BCrypt.HashPassword(registerUser.Password);
            var user = await this.db.Users.AddAsync(new User()
                                                    {
                                                            Email = registerUser.Email,
                                                            Password = passwordHash,
                                                    });

            var userVm = new UserVM()
                         {
                                 Email = user.Entity.Email,
                         };

            var identity = await GetIdentityOrDefaultAsync(new LoginModel()
                                                           {
                                                                   Email = registerUser.Email,
                                                                   Password = registerUser.Password
                                                           });

            var encodedJwt = CreateJwtSecurityToken(identity);

            return Ok(userVm);
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(LoginModel authorizedUser)
        {
            var identity = await GetIdentityOrDefaultAsync(authorizedUser);
            if (identity == null)
                return BadRequest(new { errorText = "Invalid username or password." });

            var encodedJwt = CreateJwtSecurityToken(identity);

            var response = new
                           {
                                   access_token = encodedJwt,
                                   username = identity.Name
                           };

            return Ok(response);
        }

        private async Task<ClaimsIdentity> GetIdentityOrDefaultAsync(LoginModel authorizedUser)
        {
            var user = await this.db.Users.FirstOrDefaultAsync(x => x.Email == authorizedUser.Email
                                                                 && x.Password == BCrypt.HashPassword(authorizedUser.Password));

            if (user == null)
                return null;

            var userVm = new UserVM()
                         {
                                 Id = user.Id,
                                 FullName = user.FullName,
                                 Email = user.Email,
                                 Password = user.Password,
                                 DateOfBirthday = user.DateOfBirthday,
                                 AvatarId = user.AvatarId,
                         };

            var claims = new List<Claim>
                         {
                                 new Claim(ClaimsIdentity.DefaultNameClaimType, userVm.Email),
                                 // new Claim(ClaimsIdentity.DefaultRoleClaimType, person.Role)
                         };

            var claimsIdentity =
                    new ClaimsIdentity(claims, "Token", ClaimsIdentity.DefaultNameClaimType,
                                       ClaimsIdentity.DefaultRoleClaimType);

            return claimsIdentity;
        }

        private static string CreateJwtSecurityToken(ClaimsIdentity identity)
        {
            var now = DateTime.UtcNow;
            var jwt = new JwtSecurityToken(
                                           TokenForUser.ISSUER,
                                           TokenForUser.AUDIENCE,
                                           notBefore: now,
                                           claims: identity.Claims,
                                           expires: now.Add(TimeSpan.FromMinutes(TokenForUser.LIFETIME)),
                                           signingCredentials: new SigningCredentials(TokenForUser.GetSymmetricSecurityKey(),
                                                                                      SecurityAlgorithms.HmacSha256));

            return new JwtSecurityTokenHandler().WriteToken(jwt);
        }
    }
}