using System.Collections.Generic;
using System.Linq;

namespace ExercicioTimeshare
{
     public interface IProductDatabaseContract
    {
        void Add(Product p);
        void Delete(Product p);
        Product[] GetAll();
    }

    public class ProductDatabase : IProductDatabaseContract
    {
        public static IProductDatabaseContract shared = new ProductDatabase();
        public List<Product> products = new List<Product>();

        private ProductDatabase() { }

        public void Add(Product p)
        {         
            products.Add(p);
        }

        public void Delete(Product p)
        {
            products.Remove(p);
        }

        public Product[] GetAll()
        {
            return products.ToArray();     
        }
    }
}