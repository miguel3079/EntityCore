using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Entity.Model;
using Newtonsoft.Json;
using Entity.Model.Manager;

namespace Entity.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        UserManager _userManager;

        // GET api/values
        [HttpGet]
        public string Get()
        {
            _userManager = new UserManager();
            return JsonConvert.SerializeObject(_userManager.GetUsers());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
