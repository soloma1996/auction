using auction.DAL.Model;
using System;
using System.Data.Entity.ModelConfiguration;

namespace auction.DAL.Configuration
{
    public class UserConfig : EntityTypeConfiguration<User>
    {
        public UserConfig()
        {
            Property(x => x.Surname).HasMaxLength(100);
            Property(x => x.Forename).HasMaxLength(100);
        }
    }
}
