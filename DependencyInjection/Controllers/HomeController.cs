using DependencyInjection.Models;
using DependencyInjection.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository _repository;
        private readonly ProductTotalizer _productTotalizer;

        public HomeController(IRepository repository, ProductTotalizer productTotalizer)
        {
            _repository = repository;
            _productTotalizer = productTotalizer;
        }

        public ViewResult Index()
        {
            ViewBag.HomeController = _repository.ToString();
            ViewBag.Total = _productTotalizer.Repository.ToString();
            return View(_repository.Products);
        }
    }
}
