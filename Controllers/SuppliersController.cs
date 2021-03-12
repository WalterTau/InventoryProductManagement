using CashCrusadersFranchising.API.Models;
using CashCrusadersFranchising.API.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashCrusadersFranchising.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuppliersController : Controller
    {
        private readonly ISuppliersService _suppliers;
        public SuppliersController(ISuppliersService suppliers)
        {
            this._suppliers = suppliers;
        }

        [HttpPost]
        [ProducesResponseType(typeof(IEnumerable<Suppliers>), 200)]
        public async Task<IActionResult> Post(Suppliers product)
        {
            return View();
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Suppliers>), 200)]
        public async Task<IActionResult> Gets()
        {
            return View();
        }
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Suppliers>), 200)]
        public async Task<IActionResult> Get(string id)
        {
            return View();
        }

        [HttpPut]
        [ProducesResponseType(typeof(IEnumerable<Suppliers>), 201)]
        public async Task<IActionResult> Put(string id)
        {
            return View();
        }
    }
}
