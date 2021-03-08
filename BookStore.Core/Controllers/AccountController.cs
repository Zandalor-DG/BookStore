namespace BookStore.Core.Controllers
{
    #region << Using >>

    using System;
    using System.Collections.Generic;
    using System.IdentityModel.Tokens.Jwt;
    using System.Linq;
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
    public class AccountController : Controller
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

        // GET: api/Account
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return await this.db.Users.ToListAsync();
        }

        // GET: api/Account/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await this.db.Users.FindAsync(id);

            if (user == null)
                return NotFound();

            return user;
        }

        // PUT: api/Account/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(int id, User user)
        {
            if (id != user.Id)
                return BadRequest();

            this.db.Entry(user).State = EntityState.Modified;

            try
            {
                await this.db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
                    return NotFound();
                else
                    throw;
            }

            return NoContent();
        }

        // POST: api/Account
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {
            this.db.Users.Add(user);
            await this.db.SaveChangesAsync();

            return CreatedAtAction("GetUser", new { id = user.Id }, user);
        }

        // DELETE: api/Account/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<User>> DeleteUser(int id)
        {
            var user = await this.db.Users.FindAsync(id);
            if (user == null)
                return NotFound();

            this.db.Users.Remove(user);
            await this.db.SaveChangesAsync();

            return user;
        }

        private bool UserExists(int id)
        {
            return this.db.Users.Any(e => e.Id == id);
        }

        [HttpPost("/token")]
        public async Task<IActionResult> Token(LoginModel authorizedUser)
        {
            var identity = await GetIdentityOrDefaultAsync(authorizedUser);
            if (identity == null)
                return BadRequest(new { errorText = "Invalid username or password." });

            var now = DateTime.UtcNow;
            // создаем JWT-токен
            var jwt = new JwtSecurityToken(
                                           TokenForUser.ISSUER,
                                           TokenForUser.AUDIENCE,
                                           notBefore: now,
                                           claims: identity.Claims,
                                           expires: now.Add(TimeSpan.FromMinutes(TokenForUser.LIFETIME)),
                                           signingCredentials: new SigningCredentials(TokenForUser.GetSymmetricSecurityKey(), SecurityAlgorithms.HmacSha256));

            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);

            var response = new
                           {
                                   access_token = encodedJwt,
                                   username = identity.Name
                           };

            return Json(response);
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
    }
}