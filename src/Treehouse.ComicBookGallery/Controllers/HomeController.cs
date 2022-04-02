using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Treehouse.ComicBookGallery.Data;
using Treehouse.ComicBookGallery.Models;

namespace Treehouse.ComicBookGallery.Controllers
{
	public class HomeController : Controller
	{
		private ComicBookRepository _comicBookRepository = null;
		public HomeController()
		{
			_comicBookRepository = new ComicBookRepository();
		}
		private readonly ILogger<HomeController> _logger;

		//public HomeController(ILogger<HomeController> logger)
		//{
		//	_logger = logger;
		//}

		public ActionResult Index()
		{
			var comicBooks = _comicBookRepository.GetComicBooks();
			return View(comicBooks);
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
	}
}