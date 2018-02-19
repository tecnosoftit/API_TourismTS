using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json;
using Services;

namespace APITourism
{
    public class AuthServerProvider : OAuthAuthorizationServerProvider
    {
        private readonly Security _sec = new Security();

        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            var parameters = context.UserName.Split('|');
            var user = _sec.GetUser(parameters[0], context.Password, parameters[1]);
            if (user != null)
            {
                var identity = new ClaimsIdentity(context.Options.AuthenticationType);
                var roles = _sec.GetRoles(user.Use_ID, parameters[1]);
                foreach (var item in roles)
                {
                    identity.AddClaim(new Claim(ClaimTypes.Role, item.Rol_name));
                }
                identity.AddClaim(new Claim(ClaimTypes.Name, user.Use_name, user.Use_surname));
                identity.AddClaim(new Claim("UserInfo", JsonConvert.SerializeObject(user)));
                identity.AddClaim(new Claim("Roles", JsonConvert.SerializeObject(roles)));
                context.Validated(identity);
            }
            else
            {
                context.SetError("Invalid Grant", "invalid Credentials");
                return;
            }
        }
    }
}