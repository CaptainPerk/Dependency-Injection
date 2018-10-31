using DependencyInjection.Models;
using DependencyInjection.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository _repository;

        public HomeController(IRepository repository)
        {
            _repository = repository;
        }

        public ViewResult Index([FromServices]ProductTotalizer productTotalizer)
        {
            ViewBag.HomeController = _repository.ToString();
            ViewBag.Totalizer = productTotalizer.Repository.ToString();
            return View(_repository.Products);
        }
    }
}
