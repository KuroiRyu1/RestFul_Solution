using RestFul_1.Models.entity;
using RestFul_1.Models.ModelData;
using RestFul_1.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Web.Http;

namespace RestFul_1.Areas.myapi.Controllers
{
    [RoutePrefix("dm")]
    public class CategoryApiController : ApiController
    {
        [Route("dms")]
        [HttpGet]
        // GET: api/CategoryApi
        //restful api service
        public IEnumerable<Category> Get()
        {
            var headerData = Request.Headers;
            string username = string.Empty;
            string password = string.Empty;
            string token = string.Empty;
            if (headerData.Contains("username"))
            {
                username = headerData.GetValues("username").First();
            }
            if (headerData.Contains("password"))
            {
                password = headerData.GetValues("pwd").First();
            }
            if (headerData.Contains("token"))
            {
                token = headerData.GetValues("tk").First();
            }
            if (AccountRep.checkToken(username,password,token)) {
                CategoryRes res = new CategoryRes();
                return res.Gets();
            }
            return new List<Category>();
        }

        // GET: api/CategoryApi/5

        public IEnumerable<string> Get(int id)
        {
            return new string[] { "value1", "value2" };
        }

        // POST: api/CategoryApi
        // must be void 
        public void Post([FromBody]string value)
        {
        }
        public void Post(Category item)
        {
            CategoryRes res = new CategoryRes();
            if(item != null)
            {
                res.Create(item);
            }
        }

        // PUT: api/CategoryApi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/CategoryApi/5
        // you can choose delete or add
        public void Delete(int id)
        {
        }
    }
}
