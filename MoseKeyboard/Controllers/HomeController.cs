using Microsoft.AspNetCore.Mvc;
using MoseBoard.DAL.Repository.IRepository;
using MoseKeyboard.Models;
using MoseKeyboard.Models.Models.ViewModel;
using System.Diagnostics;

namespace MoseKeyboard.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICategoryRepository _catRepo;
        private readonly IProductRepository _prodRepo;
        public HomeController(ILogger<HomeController> logger, IProductRepository prodRepo, ICategoryRepository catRepo)
        {
            _logger = logger;
            _prodRepo = prodRepo;
            _catRepo = catRepo;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM()
            {
                Products = _prodRepo.GetAll(includeProperties: "Category"),
                Categories = _catRepo.GetAll()
            };
            return View(homeVM);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Contact()
        {
            return View("Contact");
        }
    }
}
