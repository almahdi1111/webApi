﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace WebApi
{
    public partial class Privileges
    {
        public Privileges()
        {
            UserPrivileges = new HashSet<UserPrivileges>();
        }

        public int PrivilegeId { get; set; }
        public string PrivilegeName { get; set; }
        public string Roles { get; set; }
        public int UserId { get; set; }

        public virtual Users User { get; set; }
        public virtual ICollection<UserPrivileges> UserPrivileges { get; set; }
    }
}