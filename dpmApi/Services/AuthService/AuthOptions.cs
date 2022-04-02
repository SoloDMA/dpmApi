using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace dpmApi.Services.AuthService
{
    public class AuthOptions
    {
        public const string ISSUER = "dpmApiServer";
        public const string AUDIENCE = "dpmApiClient";
        private const string KEY = "qwas78JxxJ5478jxxqwas78JxxJ5478jxxqwas78JxxJ5478jxxqwas78JxxJ5478jxxqwas78JxxJ5478jxx";
        public const int LIFETIME = 20;
        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
        }
    }
}
