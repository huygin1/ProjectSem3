using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicServicesWebAPI.DataConnect;
using ClinicServicesWebAPI.Models;

namespace ClinicServicesWebAPI.Services
{
    public class OrdersServices : IOrders
    {
        private ClinicContext context;
        public OrdersServices(ClinicContext context)
        {
            this.context = context;
        }


        public async Task<IEnumerable<Orders>> GetOrders()
        {
            return  context.Orders.ToList();
        }
        public async Task<Orders> GetOrder(int ordersID)
        {
            Orders od = context.Orders.SingleOrDefault(o => o.OrderID.Equals(ordersID));
            if (od != null)
            {
                return od;
            }
            else
            { return null; }
        }


        public async Task<Orders> PostOrders(Orders orders)
        {
            context.Orders.Add(orders);
            context.SaveChanges();
            return orders;
        }

        public async Task<Orders> PutOrders(Orders orders)
        {
            Orders model = context.Orders.SingleOrDefault(o => o.OrderID.Equals(orders.OrderID));
            if (model != null)
            {
              //  model.OrderID = orders.OrderID;
                model.OrderDate = orders.OrderDate;
                model.OrderStatus = orders.OrderStatus;
                model.MedicineID = orders.MedicineID;
                model.AccountID = orders.AccountID;
                model.Quantity = orders.Quantity;
                model.PaymentMethod = orders.PaymentMethod;
                model.Medi_Equip_ID = orders.Medi_Equip_ID;
               
                context.SaveChanges();
                return orders;
            }
            else
            {
                return null;
            }
        }
        public async Task<Orders> DeleteOrder(int ordersID)
        {
            Orders od = context.Orders.Where(n => n.OrderID.Equals(ordersID)).FirstOrDefault();
            if (od != null)
            {
                context.Orders.Remove(od);
                context.SaveChanges();
                return null;
            }
            else
            {
                return null;
            }
        }
    }
}
