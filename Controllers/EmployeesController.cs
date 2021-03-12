using CashCrusadersFranchising.Api.Data.Entities;
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
    public class EmployeesController : Controller
    {
        private IEmployeesService _employees;
        
        public EmployeesController(IEmployeesService employees )
        {
            this._employees = employees;
            
        }

        // GET: api/<UserController>
       
        [HttpGet("{Name}")]
        public async Task<ActionResult<List<Employees>>> Get(string name)
        {
            return Ok(await _employees.GetEmployeesByManager(name));
        }

    }
}
