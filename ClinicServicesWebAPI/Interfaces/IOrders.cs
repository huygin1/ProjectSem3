using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicServicesWebAPI.Models;
namespace ClinicServicesWebAPI.Services
{
   public interface IOrders
    {
        Task<IEnumerable<Orders>> GetOrders();
        Task<Orders> GetOrder(int ordersID);
        Task<Orders> PostOrders(Orders orders);
        Task<Orders> PutOrders(Orders orders);
        Task<Orders> DeleteOrder(int ordersID);
    }
}
