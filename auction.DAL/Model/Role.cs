﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auction.DAL.Model
{
    public class Role : IdentityRole<int, User_Role>
    {
    }
}
