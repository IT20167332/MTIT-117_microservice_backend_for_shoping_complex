using market.order.Models;
namespace market.order.Data
{
    public static class OrderDataService
    {
        public static List<Models.Order> orders = new List<Models.Order>()
        {
            new Models.Order
            {
                Id = 1,
                CustomerId = 1001,
                OrderDate = new DateTime(2022, 1, 1),
                OrderItems = new List<OrderItem>()
                {
                    new OrderItem() { Id = 1, ItemId = 101, ItemName = "T-Shirt", ItemPrice = 10.0, Quantity = 2 },
                    new OrderItem() { Id = 2, ItemId = 102, ItemName = "Jeans", ItemPrice = 20.0, Quantity = 1 },
                },
            },
            new Models.Order
            {
                Id = 2,
                CustomerId = 1002,
                OrderDate = new DateTime(2022, 2, 1),
                OrderItems = new List<OrderItem>()
                {
                    new OrderItem() { Id = 3, ItemId = 103, ItemName = "Sneakers", ItemPrice = 30.0, Quantity = 1 },
                    new OrderItem() { Id = 4, ItemId = 104, ItemName = "Backpack", ItemPrice = 40.0, Quantity = 1 },
                },
            },
            new Models.Order
            {
                Id = 3,
                CustomerId = 1003,
                OrderDate = new DateTime(2022, 3, 1),
                OrderItems = new List<OrderItem>()
                {
                    new OrderItem() { Id = 5, ItemId = 105, ItemName = "Watch", ItemPrice = 50.0, Quantity = 1 },
                },
            },
            new Models.Order
            {
                Id = 4,
                CustomerId = 1004,
                OrderDate = new DateTime(2022, 4, 1),
                OrderItems = new List<OrderItem>()
                {
                    new OrderItem() { Id = 6, ItemId = 106, ItemName = "Sunglasses", ItemPrice = 60.0, Quantity = 1 },
                    new OrderItem() { Id = 7, ItemId = 107, ItemName = "Hat", ItemPrice = 70.0, Quantity = 2 },
                },
            },
            new Models.Order
            {
                Id = 5,
                CustomerId = 1005,
                OrderDate = new DateTime(2022, 5, 1),
                OrderItems = new List<OrderItem>()
                {
                    new OrderItem() { Id = 8, ItemId = 108, ItemName = "Phone Case", ItemPrice = 5.0, Quantity = 3 },
                },
            },
            new Models.Order
            {
                Id = 6,
                CustomerId = 1006,
                OrderDate = new DateTime(2022, 6, 1),
                OrderItems = null,
            },
        };
    }
}
