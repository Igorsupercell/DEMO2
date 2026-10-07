using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    public class OrderItemRepository
    {
        public OrderItem Retrieve(int orderItemId)
        {
            OrderItem orderItem = new OrderItem(orderItemId);
            // Код извлечения из БД...
            return orderItem;
        }

        public bool Save(OrderItem orderItem)
        {
            // Код сохранения в БД...
            return true;
        }
    }
}
