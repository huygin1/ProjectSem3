using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicServicesWebAPI.Models;
using ClinicServicesWebAPI.Services;

namespace ClinicServicesWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private IOrders iorders;
        public OrdersController(IOrders iorders)
        {
            this.iorders = iorders;
        }
        [HttpGet()]
        public async Task<IEnumerable<Orders>> GetOrders()
        {
            return await iorders.GetOrders();
        }
        [HttpGet("{ordersID}")]
        public async Task<Orders> GetOrder(int ordersID)
        {
            return await iorders.GetOrder(ordersID);
        }
        [HttpPost()]
        public async Task<Orders> PostOrders(Orders orders)
        {
            return await iorders.PostOrders(orders);
        }
        [HttpPut()]
        public async Task<Orders> PutOrders(Orders orders)
        {
            return await iorders.PutOrders(orders);
        }
        [HttpDelete("{ordersID}")]
        public async Task<Orders> DeleteOrder(int ordersID)
        {
            return await iorders.DeleteOrder(ordersID);
        }
    }
}
