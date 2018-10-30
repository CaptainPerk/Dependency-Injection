using DependencyInjection.Models;
using DependencyInjection.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        public IRepository Repository { get; set; } = new MemoryRepository();

        public ViewResult Index() => View(Repository.Products);
    }
}
