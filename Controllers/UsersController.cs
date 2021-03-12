using CashCrusadersFranchising.API.Models.Users;
using CashCrusadersFranchising.API.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashCrusadersFranchising.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        private IUsers _user;
        public UsersController(IUsers user )
        {
            this._user = user;
            
        }

        // GET: api/<UserController>
        [HttpGet]

        public async Task<ActionResult<List<Users>>> Get()
        {
            return Ok(await _user.GetUsers());
        }

        [HttpGet("{Categories}")]
        public async Task<ActionResult<List<Users>>> GetSearchedType(string categories)
        {
            return Ok(await _user.GetCategories(categories));
        }

    }
}
