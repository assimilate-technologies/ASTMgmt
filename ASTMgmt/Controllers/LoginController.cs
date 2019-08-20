using ASTMgmt.BusinessLogic;
using ASTMgmt.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ASTMgmt.Controllers
{
    public class LoginController :ApiController
    {
        [HttpPost]
        public IHttpActionResult Authenticate([FromBody] LoginViewModel loginViewModel)
        {
            return Ok( new LoginBL().Authenticate(loginViewModel));
        }

    }
}