﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sladko_Izkushenie.Data
{
    public class Users:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        ICollection<Orders> Orders { get; set; }
    }
}
