using Microsoft.AspNet.Identity.EntityFramework;
using Vitly.Security.Core.Models;

namespace Vitly.Security.Persistence
{
    public class VitlySecurityContext : IdentityDbContext<VitlyUser>
    {
        public VitlySecurityContext()
            : base("VitlySecurityContext", false) { }

        public static VitlySecurityContext Create()
        {
            return new VitlySecurityContext();
        }
    }
}