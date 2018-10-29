using System.Collections.Generic;

namespace DependencyInjection.Models.Interfaces
{
    public interface IRepository
    {
        IEnumerable<Product> Products { get; }
        Product this[string name] { get; }

        void AddProduct(Product product);
        void DeleteProduct(Product product);
    }
}
