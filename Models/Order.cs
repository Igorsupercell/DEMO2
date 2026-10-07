using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    public class Order
    {
        public Order()
        {
            OrderItems = new List<OrderItem>();
        }

        public Order(int orderId) : this()
        {
            OrderId = orderId;
        }

        public int OrderId { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int CustomerId { get; set; }

        // Адрес доставки
        public Address ShippingAddress { get; set; }

        public List<OrderItem> OrderItems { get; set; }

        public bool Validate()
        {
            var isValid = true;
            if (OrderDate == null) isValid = false;
            return isValid;
        }
    }
}
