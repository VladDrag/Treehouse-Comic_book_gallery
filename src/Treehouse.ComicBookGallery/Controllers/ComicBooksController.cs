using Microsoft.AspNetCore.Mvc;

namespace Treehouse.ComicBookGallery.Controllers
{
	public class ComicBooksController : Controller
	{
		public ActionResult Detail()
		{
			if (DateTime.Today.DayOfWeek == DayOfWeek.Wednesday)
			{
				return Redirect("/");
			}

			return Content("Learning curve");
		}
	}
}
