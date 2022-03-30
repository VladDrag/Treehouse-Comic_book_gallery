using Microsoft.AspNetCore.Mvc;

namespace Treehouse.ComicBookGallery.Controllers
{
	public class ComicBooksController : Controller
	{
		public ActionResult Detail()
		{
			return View();
		}
	}
}
