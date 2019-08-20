using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace ASTMgmt.ViewModels
{
    public class BaseViewModel : HttpResponseMessage
    {
        public BaseViewModel() : base()
        {
            base.RequestMessage = new HttpRequestMessage();
        }
        public string ErrorMessage { get; set; }
        public string InformationMessage { get; set; }
        public string Action { get; set; }
    }
}