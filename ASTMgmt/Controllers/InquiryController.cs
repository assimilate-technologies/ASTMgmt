using ASTMgmt.BusinessLogic;
using ASTMgmt.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ASTMgmt.Controllers
{
    public class InquiryController : ApiController
    {[HttpPost]
        public InquiryViewModel Inquiry(InquiryViewModel inquiryViewModel)
        {
            if (!ModelState.IsValid)
            {
                return new InquiryBL().AddInquiry(inquiryViewModel);

            }
            else
            {
                return new InquiryBL().CreateDataNotValidResponse(ModelState, inquiryViewModel);
            }
        }
    }
}
