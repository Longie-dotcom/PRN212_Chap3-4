using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4_Dictionary
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Dictionary<int, Product> Products { get; set; }
        public Category() { 
            Products = new Dictionary<int, Product>();
        }

        public void AddProduct(Product product)
        {
            if (!Products.ContainsKey(product.Id))
            {
                Products.Add(product.Id, product);
            }
        }

        public void PrintAllProducts()
        {
            foreach (KeyValuePair<int, Product> product in Products)
            {
                Console.WriteLine(product.Value);
            }
        }

        public Product GetProduct(int id)
        {
            if (!Products.ContainsKey(id))
            {
                return null;
            }
            else
            {
                return Products[id];
            }
        }

        public Dictionary<int, Product> SortProduct()
        {
            return Products
                .OrderBy(item => item.Value.Price).ToDictionary<int, Product>();
        }
        public Dictionary<int, Product> ComplexSortProduct()
        {
            return Products
                .OrderByDescending(item => item.Value.Quantity)
                .OrderBy(item => item.Value.Price)
                .ToDictionary<int, Product>();
        }

        public void EditProduct(Product p)
        {
            if (!Products.ContainsKey(p.Id))
            {
                return;
            }

            Products[p.Id] = p;
        }

        public bool RemoveProduct(int id)
        {
            if (!Products.ContainsKey(id))
            {
                return false;
            } else
            {
                return Products.Remove(id);
            }
        }
    }
}
