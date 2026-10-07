using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);
            // Код извлечения из БД...
            return order;
        }

        public bool Save(Order order)
        {
            // Код сохранения в БД...
            return true;
        }
    }
}
