namespace auction.DAL.Migrations
{
    using auction.DAL.Model;
    using Microsoft.AspNet.Identity;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<auction.DAL.AuctionContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AuctionContext context)
        {

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            var passwordHasher = new PasswordHasher();
            context.Users.AddOrUpdate(x => x.UserName, new User
            {
                UserName = "admin",
                Email = "dhbdhggh@drrgrg.ruu",
                PasswordHash = passwordHasher.HashPassword("123456"),
            });
            context.Roles.AddOrUpdate(x => x.Name, new Role
            {
                Name = "Administrator",
            });

            context.SaveChanges();

            var adminRole = context.Roles.Include(x => x.Users).Single(role => role.Name == "Administrator");
            var adminUser = context.Users.Single(user => user.UserName == "admin");

            var user_role = adminRole.Users.SingleOrDefault(ur => ur.UserId == adminUser.Id);

            if(user_role == null)
            {
                user_role = new User_Role
                {
                    RoleId = adminRole.Id,
                    UserId = adminUser.Id
                };

                adminRole.Users.Add(user_role);

                context.SaveChanges();
            }
        }
    }
}
