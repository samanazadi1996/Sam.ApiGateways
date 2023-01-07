using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services.Order.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services.Order.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class OrderController : ControllerBase
    {

        private static readonly List<Models.Order> orders = new List<Models.Order>
            {
                new Models.Order(1,1,1000),
                new Models.Order(2,2,7000),
                new Models.Order(3,1,5000)
            };


        private readonly ILogger<OrderController> _logger;

        public OrderController(ILogger<OrderController> logger)
        {
            _logger = logger;
        }

        [HttpGet("GetByPersonId/{id}")]
        public List<Models.Order> Get(int id)
        {
            return orders.Where(c => c.PersonId == id).ToList();
        }
    }
}
