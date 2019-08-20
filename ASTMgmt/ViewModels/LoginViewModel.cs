using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace ASTMgmt.ViewModels
{
    public class LoginViewModel : BaseViewModel 
    {
        public string UserId { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }

       
    }
}