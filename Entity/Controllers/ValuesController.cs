using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Entity.Model;
using Newtonsoft.Json;
using Entity.Model.Manager;
using Entity.Model.DTOs;
using System.Net;

namespace Entity.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        UserManager _userManager;

        public ValuesController()
        {
            _userManager = new UserManager();
        }

        // GET api/values
        [HttpGet]
        public string Get()
        {
            return JsonConvert.SerializeObject(_userManager.GetUsers());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return JsonConvert.SerializeObject(_userManager.GetUsersById(id));
        }

        // POST api/values
        [HttpPost]
        public bool Post([FromBody]UserDto userDto)
        {
            return _userManager.InsertNewUser(userDto);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            if (_userManager.DeleteUserById(id))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
