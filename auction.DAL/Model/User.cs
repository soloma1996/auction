using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;

namespace auction.DAL.Model
{
    public class User: IdentityUser<int, UserLogin, User_Role, Claim>
    {
        public string Forename { get; set; }
        public string Surname { get; set; }

        public virtual ICollection<Lot> Lots { get; set; } = new List<Lot>();
    }
}
