using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);
            // Код извлечения из БД...
            return product;
        }

        public bool Save(Product product)
        {
            // Код сохранения в БД...
            return true;
        }
    }
}
