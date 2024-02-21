using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace IdentityService.Infrastructure.Helpers.EncryptionHelpers
{
    public static class SecurityKeyHelper
    {
        //Simetrik olarak kimlik bilgileri şifrelenmekte yani Jwt.io içerisinde jwt açılabilir
        //Gizlemek için Asymmetric olarak güvenlik anahtarının şifrelenmesi gerekmekte
        public static SecurityKey CreateSecurityKey(string securityKey)
            => new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
    }
}