using market.order.Data;
using market.order.Models;

namespace market.order.Services
{
    public class OrderService : I_OrderService
    {
        public Models.Order? AddItem(Models.Order item)
        {
            OrderDataService.orders.Add(item);
            return item;
        }

        public bool DeleteItem(int id)
        {
            Order itemToDelete = OrderDataService.orders.FirstOrDefault(i => i.Id == id);
            if (itemToDelete != null)
            {
                OrderDataService.orders.Remove(itemToDelete);
                return true;
            }
            return false;
        }

        public List<Models.Order> GetItems ()
        {
            return OrderDataService.orders;
        }

        public Models.Order? GetItem(int id)
        {
            return OrderDataService.orders.FirstOrDefault(i => i.Id == id);
        }

        public Models.Order? UpdateItem(Order order)
        {
            var existingOrder = OrderDataService.orders.FirstOrDefault(o => o.Id == order.Id);
            if (existingOrder != null)
            {
                existingOrder.CustomerId = order.CustomerId;
                existingOrder.OrderDate = order.OrderDate;
                existingOrder.TotalAmount = order.TotalAmount;
                existingOrder.OrderItems = order.OrderItems;
                return existingOrder;
            }
            return null;
        }
    }
}
