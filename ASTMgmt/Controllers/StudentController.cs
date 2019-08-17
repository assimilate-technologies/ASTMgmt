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
		public IEnumerable<Student> Get()
		{
            return new StudentBL().GetAll();
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
