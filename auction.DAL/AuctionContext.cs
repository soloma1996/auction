using auction.DAL.Configuration;
using auction.DAL.Model;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Data.Entity;

namespace auction.DAL
{
    public class AuctionContext : IdentityDbContext<User, Role, int, UserLogin, User_Role, Claim>
    {
        public AuctionContext()
            : base(nameof(AuctionContext))
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(typeof(UserConfig).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
