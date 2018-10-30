using DependencyInjection.Models.Interfaces;
using System.Collections.Generic;

namespace DependencyInjection.Models
{
    public class DictionaryStorage : IModelStorage
    {
        private readonly Dictionary<string, Product> items = new Dictionary<string, Product>();

        public IEnumerable<Product> Items => items.Values;

        public Product this[string key]
        {
            get => items[key];
            set => items[key] = value;
        }

        public bool ContainsKey(string key) => items.ContainsKey(key);

        public void RemoveItem(string key) => items.Remove(key);
    }
}
