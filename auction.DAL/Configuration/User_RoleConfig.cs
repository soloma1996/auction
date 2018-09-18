using auction.DAL.Model;
using System;
using System.Data.Entity.ModelConfiguration;

namespace auction.DAL.Configuration
{
    public class User_RoleConfig : EntityTypeConfiguration<User_Role>
    {
        public User_RoleConfig()
        {
            HasIndex(x => new { x.RoleId, x.UserId }).IsUnique();
        }
    }
}
