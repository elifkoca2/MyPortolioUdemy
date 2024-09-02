using Microsoft.AspNetCore.Mvc;
using MyPortolioUdemy.ViewComponents.LayoutViewComponents;

namespace MyPortolioUdemy.ViewComponents.LayoutViewComponents
{
	public class _LayoutHeadComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
