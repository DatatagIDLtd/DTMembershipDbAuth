

using DTMembershipDbAuth.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace DTMembershipDbAuth.Models
{
    public class LoginResponse
    {
        public string response { get; set; }
        public MembershipUser userDetails { get; set; }
        

    }
}