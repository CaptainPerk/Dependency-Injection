using DependencyInjection.Models.Interfaces;
using System.Collections.Generic;

namespace DependencyInjection.Models
{
    public class MemoryRepository : IRepository
    {
        private readonly IModelStorage _modelStorage;

        public MemoryRepository(IModelStorage modelStorage)
        {
            _modelStorage = modelStorage;

            new List<Product>
            {
                new Product { Name = "Kayak", Price = 275M },
                new Product { Name = "Lifejacket", Price = 48.95M },
                new Product { Name = "Soccer ball", Price = 19.50M }
            }.ForEach(AddProduct);
        }

        public IEnumerable<Product> Products => _modelStorage.Items;

        public Product this[string name] => _modelStorage[name];

        public void AddProduct(Product product) => _modelStorage[product.Name] = product;

        public void DeleteProduct(Product product) => _modelStorage.RemoveItem(product.Name);
    }
}
