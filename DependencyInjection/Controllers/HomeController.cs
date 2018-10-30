using DependencyInjection.Infrastructure;
using DependencyInjection.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        public IRepository Repository { get; set; } = TypeBroker.Repository;

        public ViewResult Index() => View(Repository.Products);
    }
}
