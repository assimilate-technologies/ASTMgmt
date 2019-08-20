using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ASTMgmt.BusinessLogic;
using ASTMGMTDS.Entity;
using ASTMGMTDS.Repositories;

namespace ASTMgmt.Controllers
{
	public class StudentController : ApiController
	{
		// GET api/values
        [Authorize]
		public IEnumerable<Student> Get()
		{
            //need to delete below code as it is for only testing purpose
            var st = new Student() { studId = 1, studName = "rajesh", studEmail = "abc.com" };
            var st1 = new Student() { studId = 1, studName = "ramesh", studEmail = "abc.com" };
            List <Student> StudList = new List<Student>();
            StudList.Add(st);
            StudList.Add(st1);
            return StudList;

            //need to uncomment below line
            //return new StudentBL().GetAll();
        }

		// GET api/values/5
		public string Get(int id)
		{
			return "value";
		}

		// POST api/values
		public void Post([FromBody]string value)
		{
		}

		// PUT api/values/5
		public void Put(int id, [FromBody]string value)
		{
		}

		// DELETE api/values/5
		public void Delete(int id)
		{
		}
	}
}
