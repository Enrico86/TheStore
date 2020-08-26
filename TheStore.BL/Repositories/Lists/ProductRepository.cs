using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using TheStore.BL.Models;

namespace TheStore.BL.Repositories
{
    public class ProductRepository
    {
        private List<Product> ProductsData = new List<Product>();

        //Guardar
        public bool Save(Product newProduct)
        {
            ProductsData.Insert(ProductsData.Count, newProduct);
            return true;
        }

        //Obtener todos los productos
        public List<Product> GetProducts()
        {
            return ProductsData;
        }

        //Obtener un producto por su id
        public Product GetProductById(int productId)
        {
            return ProductsData.FirstOrDefault(p=>p.Id==productId);
        }

        //Eliminar un producto por su id
        public bool DeleteProduct(int productId)
        {
            var productToDelete = GetProductById(productId);
            if (productToDelete!=null)
            {
                ProductsData.Remove(productToDelete);
                return true;
            }
            return false;
        }
    }
}
