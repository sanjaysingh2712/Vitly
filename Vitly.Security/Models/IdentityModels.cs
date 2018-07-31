﻿using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Vitly.Security.Models
{
    // You can add profile data for the user by adding more properties to your VitlyUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class VitlyUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<VitlyUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class VitlySecurityContext : IdentityDbContext<VitlyUser>
    {
        public VitlySecurityContext()
            : base("VitlySecurityContext", throwIfV1Schema: false)
        {
        }

        public static VitlySecurityContext Create()
        {
            return new VitlySecurityContext();
        }
    }
}