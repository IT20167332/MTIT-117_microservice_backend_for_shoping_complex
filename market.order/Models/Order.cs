﻿namespace market.order.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderItem>? OrderItems { get; set; }
        public double TotalAmount { get; set; }
    }
}
