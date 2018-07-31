using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Vitly.Security.Models;

namespace Vitly.Security.Service
{
    // Configure the Vitly sign-in manager which is used in this application.
    public class VitlySignInManager : SignInManager<VitlyUser, string>
    {
        public VitlySignInManager(VitlyUserManager userManager, IAuthenticationManager authenticationManager)
            : base(userManager, authenticationManager) { }

        public override Task<ClaimsIdentity> CreateUserIdentityAsync(VitlyUser user)
        {
            return user.GenerateUserIdentityAsync((VitlyUserManager) this.UserManager);
        }

        public static VitlySignInManager Create(IdentityFactoryOptions<VitlySignInManager> options,
            IOwinContext context)
        {
            return new VitlySignInManager(context.GetUserManager<VitlyUserManager>(), context.Authentication);
        }
    }
}