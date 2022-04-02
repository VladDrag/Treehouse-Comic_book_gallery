using Microsoft.AspNetCore.Mvc;
using Treehouse.ComicBookGallery.Data;

namespace Treehouse.ComicBookGallery.Controllers
{
	public class HomeController : Controller
	{
		private ComicBookRepository _comicBookRepository = null;
		public HomeController()
		{
			_comicBookRepository = new ComicBookRepository();
		}
		public ActionResult Index()
		{
			var comicBooks = _comicBookRepository.GetComicBooks();
			return View(comicBooks);
		}
	}
}