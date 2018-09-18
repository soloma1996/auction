using Microsoft.AspNet.Identity.EntityFramework;
using System;

namespace auction.DAL.Model
{
    public class User_Role : IdentityUserRole<int>
    {
        public virtual User User { get; set; }

        public virtual Role Role { get; set; }
    }
}
