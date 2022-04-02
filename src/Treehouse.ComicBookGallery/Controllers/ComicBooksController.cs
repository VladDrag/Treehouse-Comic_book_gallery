using Microsoft.AspNetCore.Mvc;
using Treehouse.ComicBookGallery.Data;
using Treehouse.ComicBookGallery.Models;

namespace Treehouse.ComicBookGallery.Controllers
{
	public class ComicBooksController : Controller
	{
		private ComicBookRepository _comicBookRepository = null;
		public ComicBooksController()
		{
			_comicBookRepository = new ComicBookRepository();
		}
		public ActionResult Detail(int? id)
		{
			if (id == null)
			{
				return (View(_comicBookRepository.GetComicBooK(0)));
			}
			var comicBook = _comicBookRepository.GetComicBooK((int) id);
			return View(comicBook);
		}
	}
}
