﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsMvcApp.Models
{
    public class UserRoleViewModel
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public string UserName { get; set; }
        public string RoleName { get; set; }

    }
}