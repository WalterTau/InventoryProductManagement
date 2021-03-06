using CashCrusadersFranchising.Api.Data;
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
    public class ProductsController : Controller
    {
        private readonly IProductService _product;
    
        public ProductsController(IProductService product)
        {
            this._product = product;
        }

        [HttpPost]
        public ActionResult Post(Product product)
        {
           return Ok(_product.Add(product));
           
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Product>), 200)]
        public async Task<IActionResult> Gets()
        {
            return View();
        }
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Product>), 200)]
        public async Task<IActionResult> Get(string id)
        {
            return View();
        }

        [HttpPut]
        [ProducesResponseType(typeof(IEnumerable<Product>), 201)]
        public async Task<IActionResult> Put(string id)
        {
            return View();
        }
    }
}
