using DependencyInjection.Models;
using DependencyInjection.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index([FromServices]ProductTotalizer productTotalizer)
        {
            var repository = HttpContext.RequestServices.GetService<IRepository>();

            ViewBag.HomeController = repository.ToString();
            ViewBag.Totalizer = productTotalizer.Repository.ToString();
            return View(repository.Products);
        }
    }
}
