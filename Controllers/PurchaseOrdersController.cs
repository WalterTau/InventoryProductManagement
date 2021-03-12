﻿using CashCrusadersFranchising.API.Models;
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
    public class PurchaseOrdersController : Controller
    {
        private readonly IPurchaseOrdersService _purchaseOrder;
        public PurchaseOrdersController(IPurchaseOrdersService purchaseOrder)
        {
            this._purchaseOrder = purchaseOrder;
        }

        [HttpPost]
        [ProducesResponseType(typeof(IEnumerable<PurchaseOrder>), 200)]
        public async Task<IActionResult> Post(PurchaseOrder product)
        {
            return View();
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<PurchaseOrder>), 200)]
        public async Task<IActionResult> Gets()
        {
            return View();
        }
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<PurchaseOrder>),200)]
        public async Task<IActionResult> Get(string id)
        {
            return View();
        }

        [HttpPut]
        [ProducesResponseType(typeof(IEnumerable<PurchaseOrder>), 201)]
        public async Task<IActionResult> Put(string id)
        {
            return View();
        }
    }
}
