using DTMembershipDbAuth.ViewModels.Account;
using DTMembershipDbAuth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DTMembershipDbAuth.Repositories;
using DTMembershipDbAuth.Helper;
using System.Web.Http.ValueProviders;
using System.Configuration;

namespace DTMembershipDbAuth.Controllers
{
    public class AccountController : BaseApiController
    {
        // GET api/values
        public AccountController()
        {
            _userDataRepository = new UserDataRepository();
            _aspConnectionString = ConfigurationManager.ConnectionStrings["DTCADConnectionString"].ConnectionString;
        }
      

        [HttpPost]
        public LoginResponse Login(Login login)
        {



            try
            {
                var aClient = new aspNetHelper();

                aClient.SetMembership(_aspConnectionString);

                var user = aClient.Login(login.username, login.password );
                
                if (user.response == null )
                {
                    //Get user info

                }

                return user;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
     
    }
}
