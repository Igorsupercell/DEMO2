using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    public class CustomerRepository
    {
        public Customer Retrieve(int customerId)
        {
            // Создаем экземпляр
            Customer customer = new Customer(customerId);

            // Здесь должен быть код запроса к БД. 
            // В качестве примера заполняем хардкодом:
            if (customerId == 1)
            {
                customer.EmailAddress = "test@example.com";
                customer.FirstName = "Иван";
                customer.LastName = "Иванов";
            }

            return customer;
        }

        public bool Save(Customer customer)
        {
            // Логика сохранения в базу данных (insert или update)
            // Если сохранение прошло успешно:
            return true;
        }
    }
}
