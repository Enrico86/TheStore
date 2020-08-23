using System;
using System.Collections.Generic;
using System.Text;
using TheStore.BL.Models;

namespace TheStore.BL.Repositories
{
    public class ProductRepository
    {
        //Guardar
        public bool Save(Product product)
        {
            return true;
        }

        //Obtener todos los productos
        public List<Product> GetProducts()
        {
            return new List<Product>();
        }

        //Obtener un producto por su id
        public Product GetProduct(int id)
        {
            return new Product();

        }

        //Eliminar un producto por su id
        public bool DeleteProduct(int id)
        {
            return true;
        }
    }
}
