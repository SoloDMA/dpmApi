using DAL.DpmContext;
using DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace dpmApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SignUpController : Controller
    {
        private DpmContext db;

        public SignUpController(DpmContext context)
        {
            db = context;
        }

        public IActionResult SignUp(string username, string password)
        {
            var account = db.Accounts.FirstOrDefault(a => a.Login == username.Trim());

            if (account != null)
            {
                return Conflict(new { errorText = "User exists" });
            }

            var user = new User() {
                Id = System.Guid.NewGuid(),
                FirstName = "",
                LastName = "",
                MiddleName = "",
                RegistrationDate = System.DateTime.Now
            };

            account = new Account()
            {
                Id = System.Guid.NewGuid(),
                Login = username.Trim(),
                Password = password.Trim(),
                UserId = user.Id
            };

            db.Users.Add(user);
            db.Accounts.Add(account);

            db.SaveChanges();

            return LocalRedirect($"~/api/auth?username={username}&password={password}");
        }
    }
}
