﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomAuthenticationMVC.DataAccess
{
    public class User
    {
        public string UserId { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailID { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public Guid ActivationCode { get; set; }
        public virtual string Roles { get; set; }

    }
}